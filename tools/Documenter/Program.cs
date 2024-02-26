using System.Text.Json;
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
	Console.WriteLine("Could not configure the application settings.");
	Environment.Exit(1);
}


List<Project> projects = new()
{
	new()
	{
		Name = "Papyrus",
		OutputDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Fallout4_Base"),
		ScriptDirectory = @"G:\Bethesda.Wiki\BGS-Handbook\tools\Documenter\Targets\Base_Papyrus",
	},
	new()
	{
		Name = "Fallout 4",
		OutputDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Fallout4_DLC00"),
		ScriptDirectory = @"G:\Bethesda.Wiki\BGS-Handbook\tools\Documenter\Targets\DLC00_Fallout",
	},
	new()
	{
		Name = "Fallout 4 - Automatron",
		OutputDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Fallout4_DLC01"),
		ScriptDirectory = @"G:\Bethesda.Wiki\BGS-Handbook\tools\Documenter\Targets\DLC01_Automatron",
	},
	new()
	{
		Name = "Fallout 4 - Wasteland Workshop",
		OutputDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Fallout4_DLC02"),
		ScriptDirectory = @"G:\Bethesda.Wiki\BGS-Handbook\tools\Documenter\Targets\DLC02_Wasteland",
	},
	new()
	{
		Name = "Fallout 4 - Far Harbor",
		OutputDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Fallout4_DLC03"),
		ScriptDirectory = @"G:\Bethesda.Wiki\BGS-Handbook\tools\Documenter\Targets\DLC03_FarHarbor"
	},
	new()
	{
		Name = "F4SE",
		OutputDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "F4SE"),
		ScriptDirectory = @"G:\Bethesda.Wiki\BGS-Handbook\tools\Documenter\Targets\F4SE",
	}
};


foreach (Project project in projects)
{
	if (project.OutputDirectory == null)
	{
		Console.WriteLine($"{project}: Skipping..");
		continue;
	}
	else
	{
		Console.WriteLine($"{project}: Starting..");
	}

	Directory.CreateDirectory(project.OutputDirectory);

	if (Directory.Exists(project.ScriptDirectory))
	{
		IEnumerable<string> pexFiles = Directory.EnumerateFiles(project.ScriptDirectory, "*.pex", SearchOption.AllDirectories);

		foreach (string pex in pexFiles)
		{
			string scriptname = pex
				.Replace(project.ScriptDirectory, "", StringComparison.InvariantCultureIgnoreCase)
				.TrimStart('\\')
				.Replace(".pex", "", StringComparison.InvariantCultureIgnoreCase)
				.Replace('\\', ':');

			Assembler.Disassemble(Settings.Assembler, project.ScriptDirectory, scriptname);
		}


		string pasDirectory = Path.Combine(project.OutputDirectory, "PAS");
		Directory.CreateDirectory(pasDirectory);


		var pasFiles = Directory.EnumerateFiles(project.ScriptDirectory, "*.pas", SearchOption.AllDirectories);
		foreach (var pas in pasFiles)
		{
			string newPath = pas.Replace(project.ScriptDirectory, pasDirectory, StringComparison.InvariantCultureIgnoreCase);
			Directory.CreateDirectory(Path.GetDirectoryName(newPath));
			File.Move(pas, newPath, true);
		}


		// Search again for the pas files in the new directory.
		pasFiles = Directory.EnumerateFiles(pasDirectory, "*.pas", SearchOption.AllDirectories);

		IEnumerable<AssemblyScript> scripts = CreateAssemblyData(project, pasFiles);


		Console.WriteLine($"{project}: Serialize CLR type to a json file.");

		string jsonFile = Path.Combine(project.OutputDirectory, "papyrus.json");
		JsonSerializerOptions options = new()
		{
			WriteIndented = true
		};
		string json = JsonSerializer.Serialize(scripts, options);
		File.WriteAllText(jsonFile, json);

		Console.WriteLine($"{project}: Done");
	}
	else
	{
		Console.WriteLine($"{project}: Could not create Papyrus data file. The directory does not exist. '{project.ScriptDirectory}'.");
	}

	Console.WriteLine();
}


static IEnumerable<AssemblyScript> CreateAssemblyData(Project project, IEnumerable<string> pasFiles)
{
	Console.WriteLine($"{project}: Deserialize assembly into CLR type.");

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


#region Debug

static IEnumerable<string> TargetsFromSourceImport(string importDirectory)
{
	if (!Directory.Exists(importDirectory)) return Array.Empty<string>();

	return Directory.EnumerateFiles(importDirectory, "*.psc", SearchOption.AllDirectories)
	.Select(path => path
		.Remove(0, importDirectory.Length)
		.TrimStart('\\')
		.Replace(".psc", string.Empty)
	);
}

static void OrganizeBaseScripts()
{
	string scriptDir = @"G:\Bethesda.Wiki\BGS-Handbook\tools\Documenter\Targets\DLC00_Fallout";

	IEnumerable<string> files = Directory.EnumerateFiles(scriptDir, "*.pex", SearchOption.AllDirectories);

	ScriptList? scriptList = ScriptList.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "base-targets.json"));
	var fullPaths = scriptList.Select(path => Path.Combine(scriptDir, path + ".pex")).ToList();

	var result = files.Intersect(fullPaths, StringComparer.InvariantCultureIgnoreCase).ToList();

	foreach (var current in result)
	{
		string destination = Path.Combine(scriptDir, "PEX", Path.GetFileName(current));
		Directory.CreateDirectory(Path.GetDirectoryName(destination));
		File.Copy(current, destination, true);
	}

}

#endregion
