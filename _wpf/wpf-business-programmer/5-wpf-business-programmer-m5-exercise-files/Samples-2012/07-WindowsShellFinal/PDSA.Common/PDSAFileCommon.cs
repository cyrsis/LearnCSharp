using System;
using System.IO;
using System.Linq;

namespace PDSA.Common
{
	public class PDSAFileCommon
	{
		/// <summary>
		/// Gets the current directory in which your application is running
		/// If you are running in VS.NET it will remove the \bin folder from the path.
		/// </summary>
		/// <returns>The current directory</returns>
		public static string GetCurrentDirectory()
		{
			string ret = (from assembly in
											AppDomain.CurrentDomain.GetAssemblies()
										where assembly.CodeBase.EndsWith(".exe")
										select Path.GetDirectoryName(
										assembly.CodeBase.Replace("file:///", ""))).FirstOrDefault();

			if (ret.IndexOf(@"\bin") > 0)
				ret = ret.Substring(0, ret.LastIndexOf(@"\bin"));

			return ret;
		}
	}
}