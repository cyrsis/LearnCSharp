using Sixeyed.Disposable.ConsoleApp.ServiceAgents.WordCount;

namespace Sixeyed.Disposable.ConsoleApp
{
    public class ApiClient
    {
        public int GetWordCount(string input)
        {
            int wordCount = 0;
            using (var client = new WordCountServiceClient())
            {
                wordCount = client.GetWordCount(input);
                client.Close();
            }
            return wordCount;
        }
    }
}
