using System.Diagnostics;

namespace BGS.Archives;

internal static class Archiver
{

	public static void Extract(string executable, string archiveFile, string outputDirectory)
	{
		if (!File.Exists(executable))
			return;

		if (!string.Equals(Path.GetExtension(archiveFile), ".ba2", StringComparison.InvariantCultureIgnoreCase))
			return;

		if (!File.Exists(archiveFile))
			return;

		Directory.CreateDirectory(outputDirectory);

		Process process = new()
		{
			StartInfo = new ProcessStartInfo()
			{
				FileName = executable,
				WorkingDirectory = Path.GetDirectoryName(outputDirectory),
				Arguments = $"\"{archiveFile}\" -extract=\"{outputDirectory}\" -quiet",
				UseShellExecute = false,
				RedirectStandardOutput = true
			}
		};

		process.Start();
		process.WaitForExit();
	}

}
