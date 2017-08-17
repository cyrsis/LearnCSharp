using System.Diagnostics;
using System.Reflection;

namespace Demo
{
    public static class MethodTimeLogger
    {
        public static void Log(MethodBase methodBase, long milliseconds)
        {
            Debug.WriteLine("Customized logging goes here " + milliseconds);
        }
    }
}
