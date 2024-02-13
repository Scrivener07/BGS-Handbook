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
		AssemblyInfo element = new();

		while (stream.ReadTokens() is string[] tokens)
		{
			if (tokens[Tag] == ".info")
			{
				continue;
			}
			else if (tokens[Tag] == ".source")
			{
				if (tokens.Length > 1)
				{ element.Source = tokens[1]; }
			}
			else if (tokens[Tag] == ".modifyTime")
			{
				if (tokens.Length > 1)
				{ element.ModifyTime = int.Parse(tokens[1]); }
			}
			else if (tokens[Tag] == ".compileTime")
			{
				if (tokens.Length > 1)
				{ element.CompileTime = int.Parse(tokens[1]); }
			}
			else if (tokens[Tag] == ".user")
			{
				if (tokens.Length > 1)
				{ element.User = tokens[1]; }
			}
			else if (tokens[Tag] == ".computer")
			{
				if (tokens.Length > 1)
				{ element.Computer = tokens[1]; }
			}
			else if (tokens[Tag] == ".endInfo")
			{
				return element;
			}
			else
			{
				Console.WriteLine($"Encountered an unexpected {tokens[Tag]} token tag.");
				return element;
			}
		}

		return element;
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
			else if (tokens[Tag] == ".endUserFlagsRef")
			{
				return flags;
			}
			else if (tokens[Tag] == ".flag")
			{
				if (UserFlag(tokens) is AssemblyUserFlag flag)
				{
					flags.Add(flag);
				}
				continue;
			}
			else
			{
				Console.WriteLine($"Encountered an unexpected {tokens[Tag]} token tag.");
				return flags;
			}
		}

		return flags;
	}


	private static AssemblyUserFlag? UserFlag(string[] arguments)
	{
		if (arguments.Length > Tag && arguments[Tag] == ".flag")
		{
			AssemblyUserFlag element = new();

			for (int index = 1; index < arguments.Length; index++)
			{
				if (index == 1)
				{
					element.Name = arguments[index];
				}
				else if (index == 2)
				{
					element.Value = int.Parse(arguments[index]);
				}
				else if (index == 3)
				{
					element.Debug = arguments[index];
				}
				else
				{
					return element;
				}
			}

			return element;
		}
		else
		{
			return null;
		}
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
				if (Object(stream, tokens) is AssemblyObject assemblyObject)
				{
					table.Add(assemblyObject);
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


	private static AssemblyObject? Object(AssemblyReader stream, string[] arguments)
	{
		if (arguments.Length > Tag && arguments[Tag] == ".object")
		{
			AssemblyObject? element = new();

			for (int index = 1; index < arguments.Length; index++)
			{
				if (index == 1)
				{
					element.Name = arguments[index];
				}
				else if (index == 2)
				{
					element.Extends = arguments[index];
				}
				else
				{
					break;
				}
			}

			while (stream.ReadTokens() is string[] tokens)
			{
				if (tokens[Tag] == ".endObject")
				{
					return element;
				}
				else if (tokens[Tag] == ".userFlags")
				{
					if (tokens.Length > 1)
					{
						element.UserFlags = int.Parse(tokens[1]);
					}
					continue;
				}
				else if (tokens[Tag] == ".docString")
				{
					if (tokens.Length > 1)
					{
						element.DocString = tokens[1];
					}
					continue;
				}
				else if (tokens[Tag] == ".autoState")
				{
					if (tokens.Length > 1)
					{
						element.AutoState = tokens[1];
					}
					continue;
				}
				else if (tokens[Tag] == ".stateTable")
				{
					element.StateTable = StateTable(stream);
					continue;
				}
				else
				{
					Console.WriteLine($"Encountered an unexpected {arguments[Tag]}{tokens[Tag]} token tag.");
					continue;
				}
			}

			return element;
		}
		else
		{
			return null;
		}
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
				if (State(stream, tokens) is AssemblyState element)
				{
					table.Add(element);
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


	private static AssemblyState? State(AssemblyReader stream, string[] arguments)
	{
		if (arguments.Length > Tag && arguments[Tag] == ".state")
		{
			AssemblyState element = new();

			// Get the object fields.
			if (arguments.Length > 1)
			{
				element.Name = arguments[1];
			}

			List<AssemblyFunction> functions = new();
			element.Functions = functions;

			// Get the object elements.
			while (stream.ReadTokens() is string[] tokens)
			{
				if (tokens[Tag] == ".endState")
				{
					return element;
				}
				else if (tokens[Tag] == ".function")
				{
					if (Function(stream, tokens) is AssemblyFunction function)
					{
						functions.Add(function);
					}
					continue;
				}
				else
				{
					Console.WriteLine($"Encountered an unexpected {tokens[Tag]} token tag.");
					continue;
				}
			}

			return element;
		}
		else
		{
			return null;
		}
	}


	private static AssemblyFunction? Function(AssemblyReader stream, string[] arguments)
	{
		if (arguments.Length > Tag && arguments[Tag] == ".function")
		{
			AssemblyFunction element = new();

			// Get the object fields.
			for (int index = 1; index < arguments.Length; index++)
			{
				if (index == 1)
				{
					element.Name = arguments[index];
				}
				else if (index == 2)
				{
					element.Static = arguments[index] == "static";
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
					return element;
				}
				else if (functionTokens[Tag] == ".userFlags")
				{
					if (functionTokens.Length > 1)
					{
						element.UserFlags = int.Parse(functionTokens[1]);
					}
					continue;
				}
				else if (functionTokens[Tag] == ".docString")
				{
					if (functionTokens.Length > 1)
					{
						element.DocString = functionTokens[1];
					}
					continue;
				}
				else if (functionTokens[Tag] == ".return")
				{
					if (functionTokens.Length > 1)
					{
						element.Return = functionTokens[1];
					}
					continue;
				}
				else if (functionTokens[Tag] == ".paramTable")
				{
					element.ParamTable = ParameterTable(stream);
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

			return element;
		}
		else
		{
			return null;
		}
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
