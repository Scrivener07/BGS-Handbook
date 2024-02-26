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
		return line.Trim().Replace("\\\\", "/");
	}


	private static string[] Tokenize(string line)
	{
		line = line.Cut(';', out string? comment).Trim();
		if (comment != null)
			comment = comment.TrimStart(';').Trim();

		line = line.Cut('"', out string? quoted).Trim();
		if (quoted != null)
			quoted = quoted.Trim('"').Trim();

		string[] tokens = line.Split(' ');

		if (!string.IsNullOrWhiteSpace(comment))
			tokens = tokens.Append(comment).ToArray();

		if (!string.IsNullOrWhiteSpace(quoted))
			tokens = tokens.Append(quoted).ToArray();

		return tokens;
	}


}
