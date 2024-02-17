using System.Diagnostics;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using Papyrus;

Console.WriteLine("Read application settings");

IConfigurationBuilder builder = new ConfigurationBuilder()
	.SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
	.AddJsonFile(nameof(AppSettings) + ".json")
	.AddCommandLine(Environment.GetCommandLineArgs());

IConfiguration configuration = builder.Build();


AppSettings? Settings = configuration.GetSection(nameof(AppSettings)).Get<AppSettings>();
if (Settings != null)
{
	Console.WriteLine($"\t- {nameof(Settings.Archiver)}: {Settings.Archiver}");
	Console.WriteLine($"\t- {nameof(Settings.Assembler)}: {Settings.Assembler}");
	Console.WriteLine($"\t- {nameof(Settings.ScriptSource)}: {Settings.ScriptSource}");
	Console.WriteLine($"\t- {nameof(Settings.ScriptExecutable)}: {Settings.ScriptExecutable}");
}
else
{
	Environment.Exit(1);
}

Console.WriteLine();


Console.WriteLine("Determine script targets.");
IEnumerable<string> targets = GetScriptTargets(Settings.ScriptSource);
SaveTargets("targets.txt", targets);

Console.WriteLine("Disassemble compiled scripts into assembly files.");
IEnumerable<string> pexFiles = FindTargetFiles(Settings.ScriptExecutable, "pex", targets);
RunAssembler(Settings.Assembler, pexFiles);

Console.WriteLine("Deserialize assembly into CLR type.");
IEnumerable<string> pasFiles = FindTargetFiles(Settings.ScriptExecutable, "pas", targets);
pasFiles = Extensions.MoveFiles(pasFiles, Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PAS"));
IEnumerable<AssemblyScript> assemblyObjects = CreateAssemblyScripts(pasFiles);

Console.WriteLine("Serialize CLR type to a json file.");
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
	return names.Any(text => text.Equals(name, StringComparison.InvariantCultureIgnoreCase));
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

	Process process = new()
	{
		StartInfo = new ProcessStartInfo()
		{
			FileName = executable,
			Arguments = $"\"{Path.GetFileNameWithoutExtension(file)}\" -D",
			WorkingDirectory = Path.GetDirectoryName(file),
			UseShellExecute = false,
			RedirectStandardOutput = true
		}
	};

	process.Start();
	process.WaitForExit(5000);
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
