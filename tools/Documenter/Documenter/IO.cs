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

}