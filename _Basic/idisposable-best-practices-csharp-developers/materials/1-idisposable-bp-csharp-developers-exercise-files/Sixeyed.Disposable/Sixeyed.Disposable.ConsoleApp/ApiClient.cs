using Sixeyed.Disposable.ConsoleApp.ServiceAgents.WordCount;

namespace Sixeyed.Disposable.ConsoleApp
{
    public class ApiClient
    {
        public int GetWordCount(string input)
        {
            var client = new WordCountServiceClient();
            return client.GetWordCount(input);
        }
    }
}
