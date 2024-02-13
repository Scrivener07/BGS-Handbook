namespace Papyrus;

internal static class AssemblyFile
{
	private const int Tag = 0;


	/// <summary>
	/// Deserializes a new assembly object from the given file path.
	/// </summary>
	/// <param name="file">The assembly file to use.</param>
	/// <returns>An object representation of the script assembly.</returns>
	public static AssemblyScript? New(string file)
	{
		if (!File.Exists(file)) return null;
		try
		{
			using (AssemblyReader stream = new(file))
			{
				return new AssemblyScript()
				{
					Info = Info(stream),
					UserFlagsRef = UserFlags(stream),
					ObjectTable = ObjectTable(stream)
				};
			}
		}
		catch (IOException exception)
		{
			Console.WriteLine("The file could not be read:");
			Console.WriteLine(exception.Message);
		}

		return null;
	}


	private static AssemblyInfo Info(AssemblyReader stream)
	{
		AssemblyInfo info = new();

		while (stream.ReadTokens() is string[] tokens)
		{
			if (tokens[Tag] == ".info")
			{
				continue;
			}
			else if (tokens[Tag] == ".source")
			{
				if (tokens.Length > 1)
				{ info.Source = tokens[1]; }
			}
			else if (tokens[Tag] == ".modifyTime")
			{
				if (tokens.Length > 1)
				{ info.ModifyTime = int.Parse(tokens[1]); }
			}
			else if (tokens[Tag] == ".compileTime")
			{
				if (tokens.Length > 1)
				{ info.CompileTime = int.Parse(tokens[1]); }
			}
			else if (tokens[Tag] == ".user")
			{
				if (tokens.Length > 1)
				{ info.User = tokens[1]; }
			}
			else if (tokens[Tag] == ".computer")
			{
				if (tokens.Length > 1)
				{ info.Computer = tokens[1]; }
			}
			else if (tokens[Tag] == ".endInfo")
			{
				return info;
			}
			else
			{
				Console.WriteLine($"Encountered an unexpected {tokens[Tag]} token tag.");
				return info;
			}
		}

		return info;
	}


	private static IEnumerable<AssemblyUserFlag> UserFlags(AssemblyReader stream)
	{
		List<AssemblyUserFlag> flags = new();

		while (stream.ReadTokens() is string[] tokens)
		{
			if (tokens[Tag] == ".userFlagsRef")
			{
				continue;
			}
			else if (tokens[Tag] == ".flag")
			{
				AssemblyUserFlag flag = new();

				for (int index = 1; index < tokens.Length; index++)
				{
					if (index == 1)
					{
						flag.Name = tokens[index];
					}
					else if (index == 2)
					{
						flag.Value = int.Parse(tokens[index]);
					}
					else if (index == 3)
					{
						flag.Debug = tokens[index];
					}
					else
					{
						break;
					}
				}

				flags.Add(flag);
			}
			else if (tokens[Tag] == ".endUserFlagsRef")
			{
				return flags;
			}
			else
			{
				Console.WriteLine($"Encountered an unexpected {tokens[Tag]} token tag.");
				return flags;
			}
		}

		return flags;
	}


	private static IEnumerable<AssemblyObject> ObjectTable(AssemblyReader stream)
	{
		List<AssemblyObject> table = new();
		while (stream.ReadTokens() is string[] tokens)
		{
			if (tokens[Tag] == ".objectTable")
			{
				continue;
			}
			else if (tokens[Tag] == ".endObjectTable")
			{
				return table;
			}
			else if (tokens[Tag] == ".object")
			{
				AssemblyObject? assemblyObject = new AssemblyObject();

				// Get the object fields.
				for (int index = 1; index < tokens.Length; index++)
				{
					if (index == 1)
					{
						assemblyObject.Name = tokens[index];
					}
					else if (index == 2)
					{
						assemblyObject.Extends = tokens[index];
					}
					else
					{
						break;
					}
				}

				// Get the object elements.
				while (stream.ReadTokens() is string[] objectTokens)
				{
					if (objectTokens[Tag] == ".endObject")
					{
						table.Add(assemblyObject);
						break;
					}
					else if (objectTokens[Tag] == ".userFlags")
					{
						if (objectTokens.Length > 1)
						{
							assemblyObject.UserFlags = int.Parse(objectTokens[1]);
						}
						continue;
					}
					else if (objectTokens[Tag] == ".docString")
					{
						if (objectTokens.Length > 1)
						{
							assemblyObject.DocString = objectTokens[1];
						}
						continue;
					}
					else if (objectTokens[Tag] == ".autoState")
					{
						if (objectTokens.Length > 1)
						{
							assemblyObject.AutoState = objectTokens[1];
						}
						continue;
					}
					else if (objectTokens[Tag] == ".stateTable")
					{
						assemblyObject.StateTable = StateTable(stream);
						continue;
					}
					else
					{ // TODO: parse the member tables
						Console.WriteLine($"Encountered an unexpected {tokens[Tag]}{objectTokens[Tag]} token tag.");
						continue; // skip until `.endObject` tag.
					}
				}

				continue;
			}
			else
			{
				Console.WriteLine($"Encountered an unexpected {tokens[Tag]} token tag.");
				continue;
			}
		}

		return table;
	}


	private static IEnumerable<AssemblyState> StateTable(AssemblyReader stream)
	{
		List<AssemblyState> table = new();
		while (stream.ReadTokens() is string[] tokens)
		{
			if (tokens[Tag] == ".stateTable")
			{
				continue;
			}
			else if (tokens[Tag] == ".endStateTable")
			{
				return table;
			}
			else if (tokens[Tag] == ".state")
			{
				AssemblyState? assemblyState = new AssemblyState();

				// Get the object fields.
				for (int index = 1; index < tokens.Length; index++)
				{
					if (index == 1)
					{
						assemblyState.Name = tokens[index];
					}
					else
					{
						break;
					}
				}

				List<AssemblyFunction> functions = new List<AssemblyFunction>();
				assemblyState.Functions = functions;

				// Get the object elements.
				// TODO: Only the function names are read for now.
				while (stream.ReadTokens() is string[] stateTokens)
				{
					if (stateTokens[Tag] == ".endState")
					{
						table.Add(assemblyState);
						break;
					}
					else if (stateTokens[Tag] == ".function")
					{
						AssemblyFunction function = new AssemblyFunction();

						// Get the object fields.
						for (int index = 1; index < stateTokens.Length; index++)
						{
							if (index == 1)
							{
								function.Name = stateTokens[index];
							}
							else if (index == 2)
							{
								function.Static = stateTokens[index] == "static";
							}
							else
							{
								break;
							}
						}

						// Get the object elements.
						while (stream.ReadTokens() is string[] functionTokens)
						{
							if (functionTokens[Tag] == ".function")
							{
								continue;
							}
							else if (functionTokens[Tag] == ".endFunction")
							{
								functions.Add(function);
								break;
							}
							else if (functionTokens[Tag] == ".userFlags")
							{
								if (functionTokens.Length > 1)
								{
									function.UserFlags = int.Parse(functionTokens[1]);
								}
								continue;
							}
							else if (functionTokens[Tag] == ".docString")
							{
								if (functionTokens.Length > 1)
								{
									function.DocString = functionTokens[1];
								}
								continue;
							}
							else if (functionTokens[Tag] == ".return")
							{
								if (functionTokens.Length > 1)
								{
									function.Return = functionTokens[1];
								}
								continue;
							}
							else if (functionTokens[Tag] == ".paramTable")
							{

								function.ParamTable = ParameterTable(stream);
								continue;
							}
							else if (functionTokens[Tag] == ".localTable")
							{ // skip
								continue;
							}
							else if (functionTokens[Tag] == ".code")
							{ // skip
								continue;
							}
							else
							{
								Console.WriteLine($"Encountered an unexpected {functionTokens[Tag]} token tag.");
								continue;
							}
						}

						continue;
					}
					else
					{
						Console.WriteLine($"Encountered an unexpected {stateTokens[Tag]} token tag.");
						continue;
					}
				}

				continue;
			}
			else
			{
				Console.WriteLine($"Encountered an unexpected {tokens[Tag]} token tag.");
				continue;
			}
		}

		return table;
	}


	private static IEnumerable<AssemblyParameter> ParameterTable(AssemblyReader stream)
	{
		List<AssemblyParameter> table = new();

		while (stream.ReadTokens() is string[] tokens)
		{
			if (tokens[Tag] == ".paramTable")
			{
				continue;
			}
			else if (tokens[Tag] == ".endParamTable")
			{
				return table;
			}
			else if (tokens[Tag] == ".param")
			{
				AssemblyParameter assemblyParameter = new();
				for (int index = 1; index < tokens.Length; index++)
				{
					if (index == 1)
					{
						assemblyParameter.Name = tokens[index];
					}
					else if (index == 2)
					{
						assemblyParameter.Type = tokens[index];
					}
					else
					{
						break;
					}
				}
				table.Add(assemblyParameter);
			}
			else
			{
				Console.WriteLine($"Encountered an unexpected {tokens[Tag]} token tag.");
				continue;
			}
		}

		return table;
	}


}
