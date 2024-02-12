namespace Papyrus;

internal static class Extensions
{


	public static IEnumerable<string> MoveFiles(IEnumerable<string> files, string destination)
	{
		List<string> values = new();
		foreach (string file in files)
		{
			Directory.CreateDirectory(destination);
			string filepath = Path.Combine(destination, Path.GetFileName(file));
			File.Move(file, filepath, true);
			values.Add(filepath);
		}
		return values;
	}


	public static string Cut(this string line, char value, out string? cut)
	{
		cut = null;
		int index = line.IndexOf(value);
		if (index > -1)
		{
			cut = line.Substring(index);
			line = line.Remove(index);
		}
		return line;
	}


}
