using System.Text.Json;
using System.Text.RegularExpressions;

string directory = string.Empty;
List<ScriptType> scripts = new();


// Read the command line arguments where first parameter is a script source directory.
if (Environment.GetCommandLineArgs() is string[] arguments)
{
	if (arguments[1] != null)
		directory = arguments[1];
	else Environment.Exit(0);
}
else
{
	Environment.Exit(0);
}

// Initialize the script data from provided script source directory.
if (Directory.Exists(directory))
{
	var files = Directory.EnumerateFiles(directory, "*.psc");
	foreach (var file in files)
	{
		ScriptType script = New(file);
		scripts.Add(script);
	}
}
else
{
	Environment.Exit(0);
}

// Write the results to the console output.
foreach (ScriptType script in scripts)
{
	Console.WriteLine(script.Name);
	foreach (string member in script.Members)
	{
		Console.WriteLine("\t- " + member);
	}
}

// Write all scripts to json files.
JsonSerializerOptions options = new()
{
	WriteIndented = true
};
string json = JsonSerializer.Serialize(scripts, options);
string filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "papyrus.json");
File.WriteAllText(filepath, json);


static ScriptType New(string file)
{
	string content = File.ReadAllText(file);
	return new ScriptType
	{
		File = file,
		Name = ParseName(content),
		Members = ParseMembers(content)
	};
}


static string ParseName(string content)
{
	const string pattern_name = @"(?<=scriptname )\b\w+\b";
	Regex regex_name = new(pattern_name, RegexOptions.IgnoreCase);
	Match match_name = regex_name.Match(content);
	return match_name.Value;
}


static IEnumerable<string> ParseMembers(string content)
{
	List<string> members = new();

	// Define the regular expression.
	const string pattern = @"(?<=function )\b\w+\b";
	Regex regex = new(pattern, RegexOptions.IgnoreCase);

	Match match = regex.Match(content);
	while (match.Success)
	{
		members.Add(match.Value);
		match = match.NextMatch();
	}

	return members;
}


public class ScriptType
{
	public string File { get; set; }

	public string Name { get; set; }

	public IEnumerable<string> Members { get; set; }

	public ScriptType()
	{
		File = string.Empty;
		Name = string.Empty;
		Members = Array.Empty<string>();
	}
}

// Selects all lines starting with a ; comment character.
// Expression: `^([;].*)`
