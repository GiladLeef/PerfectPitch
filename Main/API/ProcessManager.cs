using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Reflection;

class ProcessManager
{
	private static List<int> ProcessId = new List<int>();

	private static string ROOT = "spleeter";

	internal static void SetEnvironment()
    {
		var PYROOT = Path.Combine(ROOT, "python");
		var PYCODE = Path.Combine(PYROOT, "Scripts");
		var PYPKG = Path.Combine(PYROOT, "Lib", "site-packages");

		var PATH = Environment.GetEnvironmentVariable("PATH");

		Environment.SetEnvironmentVariable("PATH", $"{ROOT};{PYROOT};{PYCODE};{PATH}");
		Environment.SetEnvironmentVariable("PYTHONPATH", $"{PYPKG}");
	}

	internal static int Execute(string args)
	{
        Process proc = new Process
		{
			StartInfo = new ProcessStartInfo("spleeter", $"separate {args}")
			{
				CreateNoWindow = true,
				UseShellExecute = false,
				WorkingDirectory = ROOT,
				RedirectStandardError = true,
				RedirectStandardOutput = true,
			}
		};

		proc.Start();

		ProcessId.Add(proc.Id);

		proc.WaitForExit();

		ProcessId.Remove(proc.Id);

		return proc.ExitCode;
	}

	internal static string GetVersion()
    {
		Process proc = new Process
		{
			StartInfo = new ProcessStartInfo("spleeter", "--version")
			{
				CreateNoWindow = true,
				UseShellExecute = false,
				WorkingDirectory = ROOT,
				RedirectStandardError = true,
				RedirectStandardOutput = true,
			}
		};

		proc.Start();

		proc.WaitForExit();

		return proc.StandardOutput.ReadToEnd();
	}

	internal static void Stop()
	{
		Process[] process = Process.GetProcesses();

		foreach (var pid in ProcessId)
		{
			foreach (Process prs in process)
			{
				if (prs.Id == pid)
				{
					prs.Kill();
					break;
				}
			}
		}
	}
}

