namespace Documenter;

/// <summary>
/// Provides input/output releated helper methods.
/// </summary>
internal static class IO
{

	/// <summary>
	/// Saves each string as a line in a text file.
	/// </summary>
	/// <param name="lines">The string text to use.</param>
	/// <param name="filepath">The file path of the text file.</param>
	public static void SaveList(IEnumerable<string> lines, string filepath)
	{
		string contents = string.Join(Environment.NewLine, lines);
		File.WriteAllText(filepath, contents);
	}


	/// <summary>
	/// Moves each file path to the given destination directory.
	/// </summary>
	/// <param name="files">The files to move.</param>
	/// <param name="destination">The destination directory.</param>
	/// <returns></returns>
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


}