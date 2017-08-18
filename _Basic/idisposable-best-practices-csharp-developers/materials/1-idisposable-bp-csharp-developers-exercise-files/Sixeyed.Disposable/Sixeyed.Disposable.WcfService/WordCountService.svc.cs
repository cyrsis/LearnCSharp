using System.ServiceModel;

namespace Sixeyed.Disposable.WcfService
{
    [ServiceContract]
    public class WordCountService 
    {
        [OperationContract]
        public int GetWordCount(string input)
        {
            return input.Split(' ').Length;
        }
    }
}
