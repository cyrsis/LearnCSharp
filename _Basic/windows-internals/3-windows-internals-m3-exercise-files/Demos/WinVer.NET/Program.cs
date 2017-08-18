using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinVer.NET {
	class Program {
		static void Main(string[] args) {
			var ver = Environment.OSVersion;
			Console.WriteLine("Version: {0}.{1} Build: {2}", ver.Version.Major, ver.Version.Minor, ver.Version.Build);
		}
	}
}
