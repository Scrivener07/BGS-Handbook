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
				AssemblyScript script = new();
				while (stream.ReadTokens() is string[] tokens)
				{
					if (Info(stream, tokens) is AssemblyInfo info)
					{
						script.Info = info;
					}
					else if (UserFlags(stream, tokens) is IEnumerable<AssemblyUserFlag> flags)
					{
						script.UserFlagsRef = flags;
					}
					else if (ObjectTable(stream, tokens) is IEnumerable<AssemblyObject> table)
					{
						script.ObjectTable = table;
					}
				}
				return script;
			}
		}
		catch (IOException exception)
		{
			Console.WriteLine("The file could not be read:");
			Console.WriteLine(exception.Message);
		}

		return null;
	}


	private static AssemblyInfo? Info(AssemblyReader stream, string[] arguments)
	{
		if (arguments.Length > Tag && arguments[Tag] == ".info")
		{
			AssemblyInfo element = new();

			while (stream.ReadTokens() is string[] tokens)
			{
				if (tokens[Tag] == ".endInfo")
				{
					return element;
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
				else
				{
					Console.WriteLine($"Encountered an unexpected {tokens[Tag]} token tag.");
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


	private static IEnumerable<AssemblyUserFlag>? UserFlags(AssemblyReader stream, string[] arguments)
	{
		if (arguments.Length > Tag && arguments[Tag] == ".userFlagsRef")
		{
			List<AssemblyUserFlag> list = new();

			while (stream.ReadTokens() is string[] tokens)
			{
				if (tokens[Tag] == ".endUserFlagsRef")
				{
					return list;
				}
				else if (tokens[Tag] == ".flag")
				{
					if (UserFlag(tokens) is AssemblyUserFlag element)
					{
						list.Add(element);
					}
					continue;
				}
				else
				{
					Console.WriteLine($"Encountered an unexpected {tokens[Tag]} token tag.");
					return list;
				}
			}

			return list;
		}
		else
		{
			return null;
		}
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


	private static IEnumerable<AssemblyObject>? ObjectTable(AssemblyReader stream, string[] arguments)
	{
		if (arguments.Length > Tag && arguments[Tag] == ".objectTable")
		{
			List<AssemblyObject> list = new();
			while (stream.ReadTokens() is string[] tokens)
			{
				if (tokens[Tag] == ".objectTable")
				{
					continue;
				}
				else if (tokens[Tag] == ".endObjectTable")
				{
					return list;
				}
				else if (tokens[Tag] == ".object")
				{
					if (Object(stream, tokens) is AssemblyObject element)
					{
						list.Add(element);
					}
					continue;
				}
				else
				{
					Console.WriteLine($"Encountered an unexpected {tokens[Tag]} token tag.");
					continue;
				}
			}

			return list;
		}
		else
		{
			return null;
		}
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
				else if (tokens[Tag] == ".structTable")
				{
					if (StructureTable(stream, tokens) is IEnumerable<AssemblyStructure> structures)
					{
						element.StructTable = structures;
					}
					continue;
				}
				else if (tokens[Tag] == ".variableTable")
				{
					continue;
				}
				else if (tokens[Tag] == ".propertyTable")
				{
					continue;
				}
				else if (tokens[Tag] == ".propertyGroupTable")
				{
					continue;
				}
				else if (tokens[Tag] == ".stateTable")
				{
					if (StateTable(stream, tokens) is IEnumerable<AssemblyState> states)
					{
						element.StateTable = states;
					}
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


	private static IEnumerable<AssemblyState>? StateTable(AssemblyReader stream, string[] arguments)
	{
		if (arguments.Length > Tag && arguments[Tag] == ".stateTable")
		{
			List<AssemblyState> list = new();
			while (stream.ReadTokens() is string[] tokens)
			{
				if (tokens[Tag] == ".endStateTable")
				{
					return list;
				}
				else if (tokens[Tag] == ".state")
				{
					if (State(stream, tokens) is AssemblyState element)
					{
						list.Add(element);
					}
					continue;
				}
				else
				{
					Console.WriteLine($"Encountered an unexpected {tokens[Tag]} token tag.");
					continue;
				}
			}
			return list;
		}
		else
		{
			return null;
		}
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
				if (functionTokens[Tag] == ".endFunction")
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
					if (ParameterTable(stream, functionTokens) is IEnumerable<AssemblyParameter> parameters)
					{
						element.ParamTable = parameters;
					}
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


	private static IEnumerable<AssemblyParameter>? ParameterTable(AssemblyReader stream, string[] arguments)
	{
		if (arguments.Length > Tag && arguments[Tag] == ".paramTable")
		{
			List<AssemblyParameter> list = new();

			while (stream.ReadTokens() is string[] tokens)
			{
				if (tokens[Tag] == ".endParamTable")
				{
					return list;
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
					list.Add(assemblyParameter);
				}
				else
				{
					Console.WriteLine($"Encountered an unexpected {tokens[Tag]} token tag.");
					continue;
				}
			}

			return list;
		}
		else
		{
			return null;
		}
	}


	private static IEnumerable<AssemblyStructure>? StructureTable(AssemblyReader stream, string[] arguments)
	{
		if (arguments.Length > Tag && arguments[Tag] == ".structTable")
		{
			List<AssemblyStructure> list = new();
			while (stream.ReadTokens() is string[] tokens)
			{
				if (tokens[Tag] == ".endStructTable")
				{
					return list;
				}
				else if (tokens[Tag] == ".struct")
				{
					if (Structure(stream, tokens) is AssemblyStructure element)
					{
						list.Add(element);
					}
					continue;
				}
				else
				{
					Console.WriteLine($"Encountered an unexpected {tokens[Tag]} token tag.");
					continue;
				}
			}
			return list;
		}
		else
		{
			return null;
		}
	}


	// WIP
	private static AssemblyStructure? Structure(AssemblyReader stream, string[] arguments)
	{
		if (arguments.Length > Tag && arguments[Tag] == ".struct")
		{
			AssemblyStructure element = new();

			// Get the object fields.
			if (arguments.Length > 1)
			{
				element.Name = arguments[1];
			}

			// Get the object elements.
			while (stream.ReadTokens() is string[] tokens)
			{
				if (tokens[Tag] == ".endStruct")
				{
					return element;
				}
				else if (tokens[Tag] == ".variable")
				{
					continue;

					// ignore for now
					if (VariableList(stream, tokens) is IEnumerable<AssemblyVariable> variables)
					{
						element.Variables = variables;
					}
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


	// WIP
	private static IEnumerable<AssemblyVariable>? VariableList(AssemblyReader stream, string[] arguments)
	{
		if (arguments.Length > Tag && arguments[Tag] == ".variable")
		{
			List<AssemblyVariable> list = new();

			while (stream.ReadTokens() is string[] tokens)
			{
				//if (tokens[Tag] == ".variable")
				//{
				//}
				if (Variable(stream, tokens) is AssemblyVariable element)
				{
					list.Add(element);
					continue;
				}
				else if (tokens[Tag] == ".endVariable")
				{
					return list;
				}
				else
				{
					Console.WriteLine($"Encountered an unexpected {tokens[Tag]} token tag.");
					continue;
				}
			}
			return list;
		}
		else
		{
			return null;
		}
	}


	// WIP
	private static AssemblyVariable? Variable(AssemblyReader stream, string[] arguments)
	{
		if (arguments.Length > Tag && arguments[Tag] == ".variable")
		{
			AssemblyVariable element = new();

			// Get the object fields.
			for (int index = 1; index < arguments.Length; index++)
			{
				if (index == 1)
				{
					element.Name = arguments[index];
				}
				else if (index == 2)
				{
					element.Type = arguments[index];
				}
				else
				{
					break;
				}
			}

			return element;
		}
		else
		{
			return null;
		}
	}


}
