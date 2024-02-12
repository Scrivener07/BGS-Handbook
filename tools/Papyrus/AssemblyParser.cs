using System.Diagnostics;

namespace Papyrus;

internal static class AssemblyParser
{


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
			using (StreamReader stream = new(file))
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



	private static AssemblyInfo Info(StreamReader stream)
	{
		AssemblyInfo info = new();

		while (ReadTokens(stream) is string[] tokens)
		{
			if (tokens[0] == ".info")
			{
				continue;
			}
			else if (tokens[0] == ".source")
			{
				if (tokens.Length > 1)
				{ info.Source = tokens[1]; }
			}
			else if (tokens[0] == ".modifyTime")
			{
				if (tokens.Length > 1)
				{ info.ModifyTime = int.Parse(tokens[1]); }
			}
			else if (tokens[0] == ".compileTime")
			{
				if (tokens.Length > 1)
				{ info.CompileTime = int.Parse(tokens[1]); }
			}
			else if (tokens[0] == ".user")
			{
				if (tokens.Length > 1)
				{ info.User = tokens[1]; }
			}
			else if (tokens[0] == ".computer")
			{
				if (tokens.Length > 1)
				{ info.Computer = tokens[1]; }
			}
			else if (tokens[0] == ".endInfo")
			{
				return info;
			}
			else
			{
				Console.WriteLine($"Encountered an unexpected {tokens[0]} token tag.");
				return info;
			}
		}

		return info;
	}


	private static IEnumerable<AssemblyUserFlag> UserFlags(StreamReader stream)
	{
		List<AssemblyUserFlag> flags = new();

		while (ReadTokens(stream) is string[] tokens)
		{
			if (tokens[0] == ".userFlagsRef")
			{
				continue;
			}
			else if (tokens[0] == ".flag")
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
				}

				flags.Add(flag);
			}
			else if (tokens[0] == ".endUserFlagsRef")
			{
				return flags;
			}
			else
			{
				Console.WriteLine($"Encountered an unexpected {tokens[0]} token tag.");
				return flags;
			}
		}

		return flags;
	}



	private static IEnumerable<AssemblyObject> ObjectTable(StreamReader stream)
	{
		List<AssemblyObject> table = new();

		while (ReadTokens(stream) is string[] tokens)
		{
			if (tokens[0] == ".objectTable")
			{
				continue;
			}
			else if (tokens[0] == ".endObjectTable")
			{
				return table;
			}
			else
			{
				if (Object(stream) is AssemblyObject tableObject)
				{
					table.Add(tableObject);
				}
				else
				{
					return table;
				}
			}
		}

		return table;
	}


	private static AssemblyObject? Object(StreamReader stream)
	{
		AssemblyObject? obj = null;

		while (ReadTokens(stream) is string[] tokens)
		{
			if (tokens[0] == ".object")
			{
				obj = new AssemblyObject();
				for (int index = 1; index < tokens.Length; index++)
				{
					if (index == 1)
					{
						obj.Name = tokens[index];
					}
					else if (index == 2)
					{
						obj.Extends = tokens[index];
					}
				}
				continue;
			}
			else if (tokens[0] == ".endObject")
			{
				return obj;
			}
			else if (tokens[0] == ".userFlags")
			{
				if (tokens.Length >= 2)
				{
					obj.UserFlags = int.Parse(tokens[1]);
				}
				continue;
			}
			else if (tokens[0] == ".docString")
			{
				if (tokens.Length >= 2)
				{
					obj.DocString = tokens[1];
				}
				continue;
			}
			else if (tokens[0] == ".autoState")
			{
				if (tokens.Length >= 2)
				{
					obj.AutoState = tokens[1];
				}
				continue;
			}
			else
			{
				Console.WriteLine($"Encountered an unexpected {tokens[0]} token tag.");
				// TODO: parse the member tables
				return obj;
			}
		}

		return obj;
	}


	static void foobar()
	{
		// if (tokens[0] == ".userFlags")
		// {
		// 	if (tokens.Length > 1)
		// 	{ assemblyObject.UserFlags = int.Parse(tokens[1]); }
		// }
		// else if (tokens[0] == ".docString")
		// {
		// 	if (tokens.Length > 1)
		// 	{ assemblyObject.DocString = tokens[1]; }
		// }
		// else if (tokens[0] == ".autoState")
		// {
		// 	if (tokens.Length > 1)
		// 	{ assemblyObject.AutoState = tokens[1]; }
		// }

		// // Structures
		// if (tokens[0] == ".structTable") continue;
		// if (tokens[0] == ".endStructTable") continue;

		// if (tokens[0] == ".struct") continue;
		// if (tokens[0] == ".endStruct") continue;

		// if (tokens[0] == ".variable") continue;
		// if (tokens[0] == ".endVariable") continue;

		// // Fields
		// if (tokens[0] == ".variableTable") continue;
		// if (tokens[0] == ".endVariableTable") continue;

		// if (tokens[0] == ".propertyTable") continue;
		// if (tokens[0] == ".endPropertyTable") continue;

		// if (tokens[0] == ".propertyGroupTable") continue;
		// if (tokens[0] == ".endPropertyGroupTable") continue;

		// if (tokens[0] == ".stateTable") continue;
		// if (tokens[0] == ".endStateTable") continue;

		// // Functions
		// if (tokens[0] == ".state") continue;
		// if (tokens[0] == ".endState") continue;

		// if (tokens[0] == ".function")
		// {
		// 	if (tokens.Length > 1)
		// 	{ members.Add(tokens[1]); }
		// }

		throw new NotImplementedException();
	}




	#region Lines

	private static string[]? ReadTokens(StreamReader stream)
	{
		if (stream.ReadLine() is string line)
		{
			line = Normalize(line);
			return Tokenize(line);
		}
		else
		{
			return null;
		}
	}


	private static string Normalize(string line)
	{
		return line.Trim().Replace("\u0022", string.Empty).Replace("\\\\", "/");
	}


	private static string[] Tokenize(string line)
	{
		line = line.Cut(';', out string? comment).Trim();
		string[] tokens = line.Split(' ');

		if (!string.IsNullOrWhiteSpace(comment))
			return tokens.Concat([comment]).ToArray();
		else
			return tokens;
	}

	#endregion

}
