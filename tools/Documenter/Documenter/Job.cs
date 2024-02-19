using System.Text.Json;
using BGS.Archives;

namespace Documenter;

public sealed class Job
{
	public string? Name { get; set; }
	public string? Archive { get; set; }

	public ArchiveList? ArchiveTargets { get; set; }

	public Job() { }


	public void Save(string filepath)
	{
		JsonSerializerOptions options = new()
		{
			WriteIndented = true
		};
		string json = JsonSerializer.Serialize(this, options);
		File.WriteAllText(filepath, json);
	}

}
