using System.Diagnostics;

namespace BGS.Papyrus;

internal static class Assembler
{

	/// <summary>
	/// </summary>
	/// <param name="executable">The PapyrusAssembler.exe file path.</param>
	/// <param name="root">The root directory for the given script type.</param>
	/// <param name="scriptname">The script name where namespace seperators use \ character.</param>
	public static void Disassemble(string executable, string root, string scriptname)
	{
		if (!File.Exists(executable))
			return;

		if (!Directory.Exists(root))
			return;

		if (string.IsNullOrWhiteSpace(scriptname))
			return;

		if (Path.GetDirectoryName(scriptname.Replace(':', '\\')) is string path)
		{
			root = Path.Combine(root, path);
		}

		Process process = new()
		{
			StartInfo = new ProcessStartInfo()
			{
				FileName = executable,
				WorkingDirectory = root,
				Arguments = $"\"{scriptname}\" -D",
				UseShellExecute = false,
				RedirectStandardOutput = true
			}
		};

		process.Start();
		process.WaitForExit();
	}


}
