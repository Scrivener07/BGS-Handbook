using Documenter;

namespace BGS.Papyrus;

internal class AssemblyReader(string file) : StreamReader(file)
{

	public string[]? ReadTokens()
	{
		if (ReadLine() is string line)
		{
			line = Normalize(line);
			return Tokenize(line);
		}
		else
		{
			return null;
		}
	}


	private static string Normalize(string line)
	{
		// Trim white space from beginning and ending.
		// Replace back slashes with forward slashes.
		return line.Trim().Replace("\\\\", "/");
	}


	private static string[] Tokenize(string line)
	{
		// First, cut the comment off the line ending.
		line = line.Cut(';', out string? comment).Trim();
		if (comment != null)
			comment = comment.TrimStart(';').Trim();

		// After cutting the comment, cut the quoted value.
		line = line.Cut('"', out string? quoted).Trim();
		if (quoted != null)
			quoted = quoted.Trim('"').Trim();

		// Split by space character for what remains of the line.
		string[] tokens = line.Split(' ');

		// Add the quoted value.
		if (!string.IsNullOrWhiteSpace(quoted))
			tokens = tokens.Append(quoted).ToArray();

		// Add comment token to end of array.
		if (!string.IsNullOrWhiteSpace(comment))
			tokens = tokens.Append(comment).ToArray();

		// Return the tokenized line.
		return tokens;
	}


}
