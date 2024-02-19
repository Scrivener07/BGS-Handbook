using System.Text.Json;
using BGS.Archives;
using BGS.Papyrus;
using Documenter;


Console.WriteLine("Read application settings");
AppSettings? Settings = App.GetSettings();
if (Settings != null)
{
	Console.WriteLine($"- {nameof(Settings.Archiver)}: {Settings.Archiver}");
	Console.WriteLine($"- {nameof(Settings.Assembler)}: {Settings.Assembler}");
	Console.WriteLine();
}
else
{
	Console.WriteLine("No configuration settings could be found.");
	Environment.Exit(1);
}


Job job = new()
{
	Name = "Fallout4",
	Archive = @"D:\SteamLibrary\steamapps\common\Fallout 4\Data\Fallout4 - Misc.ba2",
	ArchiveTargets = ArchiveList.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "base-targets.achlist"))
};


string outputDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, job.Name);
Directory.CreateDirectory(outputDirectory);

string ba2Directory = Path.Combine(outputDirectory, "BA2");
Directory.CreateDirectory(ba2Directory);

string pexDirectory = Path.Combine(outputDirectory, "PEX");
Directory.CreateDirectory(pexDirectory);

string pasDirectory = Path.Combine(outputDirectory, "PAS");
Directory.CreateDirectory(pasDirectory);


string jobFile = Path.Combine(outputDirectory, "job.json");
string dataFile = Path.Combine(outputDirectory, "papyrus.json");
string targetsPexFile = Path.Combine(outputDirectory, "targets-pex.txt");

job.Save(jobFile);


Console.WriteLine("Extract target scripts from BA2 archive.");
Archiver.Extract(Settings.Archiver, job.Archive, ba2Directory);
Console.WriteLine();


Console.WriteLine("Determine script targets.");
List<string> archiveFiles = new List<string>();
if (job.ArchiveTargets != null)
{
	foreach (string entry in job.ArchiveTargets)
	{
		archiveFiles.Add(Path.Combine(ba2Directory, entry));
	}
}
IO.MoveFiles(archiveFiles, pexDirectory);
IO.SaveList(archiveFiles, targetsPexFile);
Console.WriteLine();



Console.WriteLine("Disassemble compiled scripts into assembly files.");
IEnumerable<string> pexFiles = FindFiles(pexDirectory, "*.pex");
Assembler.Disassemble(Settings.Assembler, pexDirectory, pexFiles);



IEnumerable<string> pasFiles = FindFiles(pexDirectory, "*.pas");
pasFiles = IO.MoveFiles(pasFiles, pasDirectory);

Console.WriteLine();



Console.WriteLine("Deserialize assembly into CLR type.");

IEnumerable<AssemblyScript> assemblyObjects = AssemblyCreate(pasFiles);
Console.WriteLine();


Console.WriteLine("Serialize CLR type to a json file.");

AssemblySave(assemblyObjects, dataFile);



#region Targets

static IEnumerable<string> FindFiles(string directory, string extension)
{
	if (Directory.Exists(directory))
		return Directory.EnumerateFiles(directory, extension);
	else
		return Array.Empty<string>();
}


static IEnumerable<string> FindScriptAssembly(string directory)
{
	if (Directory.Exists(directory))
		return Directory.EnumerateFiles(directory, "*.pas");
	else
		return Array.Empty<string>();
}


static IEnumerable<string> FindTargetFiles(string directory, string extension, IEnumerable<string> names)
{
	if (Directory.Exists(directory))
		return Directory.EnumerateFiles(directory, $"*.{extension}", SearchOption.AllDirectories).Where(file => IsTarget(file, names)).ToArray();
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


#region Assembly

static IEnumerable<AssemblyScript> AssemblyCreate(IEnumerable<string> pasFiles)
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


static void AssemblySave(IEnumerable<AssemblyScript> assemblyObjects, string filepath)
{
	JsonSerializerOptions options = new()
	{
		WriteIndented = true
	};
	string json = JsonSerializer.Serialize(assemblyObjects, options);
	File.WriteAllText(filepath, json);
}

#endregion
