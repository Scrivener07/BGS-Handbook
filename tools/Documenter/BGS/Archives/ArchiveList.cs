using System.Collections.ObjectModel;
using System.Text.Json;

namespace BGS.Archives;

public sealed class ArchiveList : Collection<string>
{


	public void Save(string filepath)
	{
		JsonSerializerOptions options = new()
		{
			WriteIndented = true
		};
		string json = JsonSerializer.Serialize(this, options);
		File.WriteAllText(filepath, json);
	}



	public static ArchiveList? Load(string filepath)
	{
		if (File.Exists(filepath))
		{
			if (File.ReadAllText(filepath) is string json)
			{
				return JsonSerializer.Deserialize<ArchiveList>(json);
			}
		}
		return null;
	}


}
