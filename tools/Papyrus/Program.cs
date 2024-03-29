﻿using System.Diagnostics;
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
pasFiles = Extensions.MoveFiles(pasFiles, Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PAS"));
IEnumerable<AssemblyScript> assemblyObjects = CreateAssemblyScripts(pasFiles);

// Serialize CLR type to a json file.
Save(assemblyObjects);



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



static IEnumerable<AssemblyScript> CreateAssemblyScripts(IEnumerable<string> pasFiles)
{
	List<AssemblyScript> scripts = new();
	foreach (string file in pasFiles)
	{
		if (AssemblyFile.New(file) is AssemblyScript script)
		{
			scripts.Add(script);
		}
	}
	return scripts;
}


static void Save(IEnumerable<AssemblyScript> assemblyObjects)
{
	JsonSerializerOptions options = new()
	{
		WriteIndented = true
	};
	string json = JsonSerializer.Serialize(assemblyObjects, options);
	string filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "papyrus.json");
	File.WriteAllText(filepath, json);
}
