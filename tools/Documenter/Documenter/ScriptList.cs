using System.Collections.ObjectModel;
using System.Text.Json;

namespace Documenter;

public sealed class ScriptList : Collection<string>
{

	public ScriptList() { }

	public ScriptList(IList<string> list) : base(list) { }


	public void Save(string filepath)
	{
		JsonSerializerOptions options = new()
		{
			WriteIndented = true
		};
		string json = JsonSerializer.Serialize(this, options);
		File.WriteAllText(filepath, json);
	}


	public static ScriptList? Load(string filepath)
	{
		if (File.Exists(filepath))
		{
			if (File.ReadAllText(filepath) is string json)
			{
				return JsonSerializer.Deserialize<ScriptList>(json);
			}
		}
		return null;
	}


}
