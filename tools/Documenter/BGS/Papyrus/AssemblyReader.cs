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
		return line.Trim().Replace("\u0022", string.Empty).Replace("\\\\", "/");
	}


	private static string[] Tokenize(string line)
	{
		line = line.Cut(';', out string? comment).Trim();
		string[] tokens = line.Split(' ');

		if (!string.IsNullOrWhiteSpace(comment))
			return tokens.Append(comment).ToArray();
		else
			return tokens;
	}


}
