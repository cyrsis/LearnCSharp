using System;
using System.IO;
using System.Threading.Tasks;

namespace CS61
{
    public class OperationLogger(Stream stream) : IDisposable
    {
        public async Task LogOperationAsync(Action action)
        {
            var name = action?.Method?.Name ?? "no name";

            try
            {
                action();
                await LogWriter.WriteLineAsync(name + " executed");
            }
            catch (Exception ex) if(ex.InnerException == null)
            {
                await LogWriter.WriteLineAsync(name + " failed");
            }
            finally
            {
                await LogWriter.FlushAsync();
            }
        }

        public void Dispose()
        {
            LogWriter.Dispose();
        }

        private StreamWriter LogWriter { get; } = new StreamWriter(stream);
    }
}
