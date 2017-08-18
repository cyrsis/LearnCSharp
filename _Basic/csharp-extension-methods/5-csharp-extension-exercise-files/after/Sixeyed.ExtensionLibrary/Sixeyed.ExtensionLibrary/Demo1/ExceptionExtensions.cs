using System.Text;

namespace System
{
    public static class ExceptionExtensions
    {
        public static string FullMessage(this Exception ex)
        {
            var builder = new StringBuilder();
            while (ex != null)
            {
                builder.AppendFormat("{0}{1}", ex.Message, Environment.NewLine);
                ex = ex.InnerException;
            }
            return builder.ToString();
        }
    }
}
