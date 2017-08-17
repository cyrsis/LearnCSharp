﻿using System.Diagnostics;
using System.IO;

namespace EndToEndSpecs.Helpers
{
	public class IISExpressRunner
	{
		//NOTE: You may need to change this if it is in use already!
		private const int IISPortNumber = 50001;

		private Process _iisProcess;

		public void StartProcess()
		{
			var startInfo = new ProcessStartInfo
			{
				CreateNoWindow = true,
				UseShellExecute = false
			};

			var pathToApp = GetPathToApplication();

			var programfiles =
				!string.IsNullOrEmpty(startInfo.EnvironmentVariables["programfiles(x86)"])
					? startInfo.EnvironmentVariables["programfiles(x86)"]
					: startInfo.EnvironmentVariables["programfiles"];

			startInfo.FileName = programfiles + @"\IIS Express\iisexpress.exe";
			startInfo.Arguments =
				string.Format("/path:\"{0}\" /port:{1}", pathToApp, IISPortNumber);

			_iisProcess = new Process { StartInfo = startInfo };

			_iisProcess.Start();
		}

		public void StopProcess()
		{
			if (_iisProcess != null && !_iisProcess.HasExited)
			{
				_iisProcess.CloseMainWindow();
				_iisProcess.Kill();
				_iisProcess.Dispose();
				_iisProcess = null;
			}
		}

		private string GetPathToApplication()
		{
			//Will be /EndToEndSpecs/bin/Debug/
			var directory = new DirectoryInfo(Directory.GetCurrentDirectory());

			var solutionDirectory = directory.Parent.Parent.Parent;

			return Path.Combine(solutionDirectory.FullName, "Web");
		}
	}
}
