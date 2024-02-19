namespace Documenter;

/// <summary>
/// Provides extensions methods for this application.
/// </summary>
internal static class Extensions
{

	/// <summary>
	/// Cuts a span of text from the given line.
	/// </summary>
	/// <param name="line">The text line to cut from.</param>
	/// <param name="value">The character to begin cutting from until the end of line.</param>
	/// <param name="cut">The span of text that was cut.</param>
	/// <returns></returns>
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
