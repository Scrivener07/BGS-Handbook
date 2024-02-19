using System.Diagnostics;

namespace BGS.Archives;

internal static class Archiver
{

	public static void Extract(string executable, string archiveFile, string extractDirectory)
	{
		if (!File.Exists(executable))
			return;

		if (!string.Equals(Path.GetExtension(archiveFile), ".ba2", StringComparison.InvariantCultureIgnoreCase))
			return;

		if (!File.Exists(archiveFile))
			return;

		Directory.CreateDirectory(extractDirectory);

		Process process = new()
		{
			StartInfo = new ProcessStartInfo()
			{
				FileName = executable,
				Arguments = $"\"{archiveFile}\" -extract=\"{extractDirectory}\" -quiet",
				WorkingDirectory = Path.GetDirectoryName(extractDirectory),
				UseShellExecute = false,
				RedirectStandardOutput = true
			}
		};

		process.Start();
		process.WaitForExit();
	}

}
