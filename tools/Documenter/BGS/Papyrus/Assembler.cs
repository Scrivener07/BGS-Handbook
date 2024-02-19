using System.Diagnostics;

namespace BGS.Papyrus;

internal static class Assembler
{

	public static void Disassemble(string executable, string directory, IEnumerable<string> pexFiles)
	{
		foreach (string file in pexFiles)
		{
			Disassemble(executable, directory, file);
		}
	}


	private static void Disassemble(string executable, string directory, string file)
	{
		if (!string.Equals(Path.GetExtension(file), ".pex", StringComparison.InvariantCultureIgnoreCase))
			return;

		if (!File.Exists(file))
			return;

		Directory.CreateDirectory(directory);

		Process process = new()
		{
			StartInfo = new ProcessStartInfo()
			{
				FileName = executable,
				Arguments = $"\"{Path.GetFileNameWithoutExtension(file)}\" -D",
				WorkingDirectory = directory,
				//UseShellExecute = false,
				//RedirectStandardOutput = true
			}
		};

		Console.WriteLine($"\nFile: {file}");
		process.Start();
		process.WaitForExit();
	}


}
