using System.Diagnostics;
using System.Text.Json;
using Papyrus;

string assembler = string.Empty;
string pscDirectory = string.Empty;
string pexDirectory = string.Empty;

// Read the command line arguments.
if (Environment.GetCommandLineArgs() is string[] arguments)
{
	assembler = arguments[1];
	pscDirectory = arguments[2];
	pexDirectory = arguments[3];
}

// Determine script targets.
IEnumerable<string> targets = GetScriptTargets(pscDirectory);
SaveTargets("targets.txt", targets);

// Disassemble compiled scripts into assembly files.
IEnumerable<string> pexFiles = FindTargetFiles(pexDirectory, "pex", targets);
RunAssembler(assembler, pexFiles);

// Deserialize assembly into CLR type.
IEnumerable<string> pasFiles = FindTargetFiles(pexDirectory, "pas", targets);
IEnumerable<ScriptObject> scriptObjects = CreateScriptObjects(pasFiles);

// Serialize CLR type to a json file.
JsonSerializerOptions options = new()
{
	WriteIndented = true
};
string json = JsonSerializer.Serialize(scriptObjects, options);
string filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "papyrus.json");
File.WriteAllText(filepath, json);



#region Targets

static IEnumerable<string> GetScriptTargets(string directory)
{
	if (Directory.Exists(directory))
		return Directory.EnumerateFiles(directory, "*.psc").Select(file => Path.GetFileNameWithoutExtension(file));
	else
		return Array.Empty<string>();
}

static void SaveTargets(string file, IEnumerable<string> names)
{
	string content = string.Join(Environment.NewLine, names);
	string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, file);
	File.WriteAllText(path, content);
}

static IEnumerable<string> FindTargetFiles(string directory, string extension, IEnumerable<string> names)
{
	if (Directory.Exists(directory))
		return Directory.EnumerateFiles(directory, $"*.{extension}").Where(file => IsTarget(file, names)).ToArray();
	else
		return Array.Empty<string>();
}

static bool IsTarget(string file, IEnumerable<string> names)
{
	file = file.Replace(".disassemble", string.Empty);
	string name = Path.GetFileNameWithoutExtension(file);
	return names.Contains(name);
}

#endregion


#region Assembler

static void RunAssembler(string assembler, IEnumerable<string> pexFiles)
{
	foreach (string file in pexFiles)
	{
		AssemblerDecompile(assembler, file);
	}
}

static void AssemblerDecompile(string executable, string file)
{
	if (!string.Equals(Path.GetExtension(file), ".pex", StringComparison.InvariantCultureIgnoreCase))
		return;

	if (!File.Exists(file))
		return;

	ProcessStartInfo info = new()
	{
		FileName = executable,
		Arguments = $"\"{Path.GetFileNameWithoutExtension(file)}\" -D",
		WorkingDirectory = Path.GetDirectoryName(file)
	};

	Process process = new();
	process.StartInfo.FileName = executable;
	process.StartInfo.Arguments = $"\"{Path.GetFileNameWithoutExtension(file)}\" -D";
	process.StartInfo.WorkingDirectory = Path.GetDirectoryName(file);
	process.Start();
	process.WaitForExit(5000);
	Console.WriteLine();
}

#endregion


#region Deserialization

static IEnumerable<ScriptObject> CreateScriptObjects(IEnumerable<string> pasFiles)
{
	List<ScriptObject> list = new();
	foreach (string file in pasFiles)
	{
		ScriptObject script = NewType(file);
		list.Add(script);
	}
	return list;
}


static ScriptObject NewType(string file)
{
	ScriptObject script = new ScriptObject();

	if (File.Exists(file))
	{
		try
		{
			var lines = File.ReadAllLines(file);
			for (var index = 0; index < lines.Length; index++)
			{
				string line = lines[index].Trim();

				if (line.StartsWith(".source "))
				{
					script.File = line.Split(' ').Skip(1).FirstOrDefault();
				}

				if (line.StartsWith(".object "))
				{
					script.Name = line.Split(' ').Skip(1).FirstOrDefault();
				}
			}
		}
		catch (IOException exception)
		{
			Console.WriteLine("The file could not be read:");
			Console.WriteLine(exception.Message);
		}
	}

	return script;
}

#endregion


namespace Papyrus
{
	public class ScriptObject
	{
		public string File { get; set; }

		public string Name { get; set; }

		public IEnumerable<string> Members { get; set; }

		public ScriptObject()
		{
			File = string.Empty;
			Name = string.Empty;
			Members = Array.Empty<string>();
		}
	}
}
