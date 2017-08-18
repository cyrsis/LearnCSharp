using System.ServiceModel;
using System.Threading;

namespace Sixeyed.Disposable.WcfService
{
    [ServiceContract]
    public class WordCountService 
    {
        [OperationContract]
        public int GetWordCount(string input)
        {
            //Thread.Sleep(750);
            return input.Split(' ').Length;
        }
    }
}
