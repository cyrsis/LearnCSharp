using Sixeyed.Disposable.DomainConsoleApp.ServiceAgents.WordCount;

namespace Sixeyed.Disposable.DomainConsoleApp
{
    public class ApiClient : IApiClient
    {
        public int GetWordCount(string input)
        {
            var client = new WordCountServiceClient();
            return client.GetWordCount(input);
        }
    }
}
