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
					Console.WriteLine($"{nameof(Info)}: Encountered an unexpected {arguments[Tag]}{tokens[Tag]} token tag.");
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
					Console.WriteLine($"{nameof(UserFlags)}: Encountered an unexpected {arguments[Tag]}{tokens[Tag]} token tag.");
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
					Console.WriteLine($"{nameof(ObjectTable)}: Encountered an unexpected {arguments[Tag]}{tokens[Tag]} token tag.");
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
					if (VariableTable(stream, tokens) is IEnumerable<AssemblyVariable> variables)
					{
						element.VariableTable = variables;
					}
					continue;
				}
				else if (tokens[Tag] == ".propertyTable")
				{
					if (PropertyTable(stream, tokens) is IEnumerable<AssemblyProperty> properties)
					{
						element.PropertyTable = properties;
					}
					continue;
				}
				else if (tokens[Tag] == ".propertyGroupTable")
				{
					if (PropertyGroupTable(stream, tokens) is IEnumerable<AssemblyPropertyGroup> groups)
					{
						element.PropertyGroupTable = groups;
					}
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
					Console.WriteLine($"{nameof(Object)}: Encountered an unexpected {arguments[Tag]}{tokens[Tag]} token tag.");
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
					Console.WriteLine($"{nameof(StateTable)}: Encountered an unexpected {arguments[Tag]}{tokens[Tag]} token tag.");
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

			// Get object attributes.
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
					Console.WriteLine($"{nameof(State)}: Encountered an unexpected {arguments[Tag]}{tokens[Tag]} token tag.");
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

			// Get object attributes.
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
			while (stream.ReadTokens() is string[] tokens)
			{
				if (tokens[Tag] == ".endFunction")
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
				else if (tokens[Tag] == ".return")
				{
					if (tokens.Length > 1)
					{
						element.Return = tokens[1];
					}
					continue;
				}
				else if (tokens[Tag] == ".paramTable")
				{
					if (ParameterTable(stream, tokens) is IEnumerable<AssemblyParameter> parameters)
					{
						element.ParamTable = parameters;
					}
					continue;
				}
				else if (tokens[Tag] == ".localTable")
				{ // skip
					continue;
				}
				else if (tokens[Tag] == ".code")
				{ // skip
					while (stream.ReadTokens() is string[] codeTokens)
					{
						if (tokens[Tag] == ".endCode")
						{
							break;
						}
						else
						{ // skip all
							continue;
						}
					}
					continue;
				}
				else
				{
					Console.WriteLine($"{nameof(Function)}: Encountered an unexpected {arguments[Tag]}{tokens[Tag]} token tag.");
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
					Console.WriteLine($"{nameof(ParameterTable)}: Encountered an unexpected {arguments[Tag]}{tokens[Tag]} token tag.");
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
					Console.WriteLine($"{nameof(StructureTable)}: Encountered an unexpected {arguments[Tag]}{tokens[Tag]} token tag.");
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


	private static AssemblyStructure? Structure(AssemblyReader stream, string[] arguments)
	{
		if (arguments.Length > Tag && arguments[Tag] == ".struct")
		{
			AssemblyStructure element = new();

			// Get object attributes.
			if (arguments.Length > 1)
			{
				element.Name = arguments[1];
			}


			List<AssemblyVariable> variables = new();
			element.Variables = variables;

			// Get the object elements.
			while (stream.ReadTokens() is string[] tokens)
			{
				if (tokens[Tag] == ".endStruct")
				{
					return element;
				}
				else if (tokens[Tag] == ".variable")
				{
					if (Variable(stream, tokens) is AssemblyVariable variable)
					{
						variables.Add(variable);
					}
					continue;
				}
				else
				{
					Console.WriteLine($"{nameof(Structure)}: Encountered an unexpected {arguments[Tag]}{tokens[Tag]} token tag.");
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


	private static IEnumerable<AssemblyVariable>? VariableTable(AssemblyReader stream, string[] arguments)
	{
		if (arguments.Length > Tag && arguments[Tag] == ".variableTable")
		{
			List<AssemblyVariable> list = new();
			while (stream.ReadTokens() is string[] tokens)
			{
				if (tokens[Tag] == ".endVariableTable")
				{
					return list;
				}
				else if (tokens[Tag] == ".variable")
				{
					if (Variable(stream, tokens) is AssemblyVariable element)
					{
						list.Add(element);
					}
					continue;
				}
				else
				{
					Console.WriteLine($"{nameof(VariableTable)}: Encountered an unexpected {arguments[Tag]}{tokens[Tag]} token tag.");
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


	private static AssemblyVariable? Variable(AssemblyReader stream, string[] arguments)
	{
		if (arguments.Length > Tag && arguments[Tag] == ".variable")
		{
			AssemblyVariable element = new();

			// Get object attributes.
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

			// Get the object elements.
			while (stream.ReadTokens() is string[] tokens)
			{
				if (tokens[Tag] == ".endVariable")
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
				else if (tokens[Tag] == ".initialValue")
				{
					if (tokens.Length > 1)
					{
						element.InitialValue = tokens[1];
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
				else
				{
					Console.WriteLine($"{nameof(Variable)}: Encountered an unexpected {arguments[Tag]}{tokens[Tag]} token tag.");
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


	private static IEnumerable<AssemblyProperty>? PropertyTable(AssemblyReader stream, string[] arguments)
	{
		if (arguments.Length > Tag && arguments[Tag] == ".propertyTable")
		{
			List<AssemblyProperty> list = new();
			while (stream.ReadTokens() is string[] tokens)
			{
				if (tokens[Tag] == ".endPropertyTable")
				{
					return list;
				}
				else if (tokens[Tag] == ".property")
				{
					if (Property(stream, tokens) is AssemblyProperty element)
					{
						list.Add(element);
					}
					continue;
				}
				else
				{
					Console.WriteLine($"{nameof(PropertyTable)}: Encountered an unexpected {arguments[Tag]}{tokens[Tag]} token tag.");
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


	private static AssemblyProperty? Property(AssemblyReader stream, string[] arguments)
	{
		if (arguments.Length > Tag && arguments[Tag] == ".property")
		{
			AssemblyProperty element = new();

			// Get object attributes.
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
				else if (index == 3)
				{
					element.IsAuto = arguments[index] == "auto";
				}
				else
				{
					break;
				}
			}

			// Get the object elements.
			while (stream.ReadTokens() is string[] tokens)
			{
				if (tokens[Tag] == ".endProperty")
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
				else if (tokens[Tag] == ".autoVar")
				{
					if (tokens.Length > 1)
					{
						element.AutoVar = tokens[1];
					}
					continue;
				}
				else
				{
					Console.WriteLine($"{nameof(Property)}: Encountered an unexpected {arguments[Tag]}{tokens[Tag]} token tag.");
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


	private static IEnumerable<AssemblyPropertyGroup>? PropertyGroupTable(AssemblyReader stream, string[] arguments)
	{
		if (arguments.Length > Tag && arguments[Tag] == ".propertyGroupTable")
		{
			List<AssemblyPropertyGroup> list = new();
			while (stream.ReadTokens() is string[] tokens)
			{
				if (tokens[Tag] == ".endPropertyGroupTable")
				{
					return list;
				}
				else if (tokens[Tag] == ".propertyGroup")
				{
					if (PropertyGroup(stream, tokens) is AssemblyPropertyGroup element)
					{
						list.Add(element);
					}
					continue;
				}
				else
				{
					Console.WriteLine($"{nameof(PropertyGroupTable)}: Encountered an unexpected {arguments[Tag]}{tokens[Tag]} token tag.");
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


	private static AssemblyPropertyGroup? PropertyGroup(AssemblyReader stream, string[] arguments)
	{
		if (arguments.Length > Tag && arguments[Tag] == ".propertyGroup")
		{
			List<string> properties = new();
			AssemblyPropertyGroup element = new()
			{
				Properties = properties
			};

			// Get object attributes.
			if (arguments.Length > 1)
			{
				element.Name = arguments[1];
			}

			// Get the object elements.
			while (stream.ReadTokens() is string[] tokens)
			{
				if (tokens[Tag] == ".endPropertyGroup")
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
				else if (tokens[Tag] == ".property")
				{
					if (tokens.Length > 1)
					{
						properties.Add(tokens[1]);
					}
					continue;
				}
				else
				{
					Console.WriteLine($"{nameof(PropertyGroup)}: Encountered an unexpected {arguments[Tag]}{tokens[Tag]} token tag.");
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


}
