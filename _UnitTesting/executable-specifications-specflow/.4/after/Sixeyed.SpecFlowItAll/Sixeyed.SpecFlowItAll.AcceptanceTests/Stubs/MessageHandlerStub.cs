using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Sixeyed.SpecFlowItAll.AcceptanceTests.Stubs
{
    [Binding]
    public class MessageHandlerStub
    {
        public static int MessageCount { get; private set; }

        public static dynamic LastOrderRequest { get; private set; }

        private MessageQueue _queue;
        private bool _isListening;
        private CancellationTokenSource _cancellationTokenSource;

        [BeforeScenario("msmqStub")]
        public void Start()
        {
            const string address = ".\\private$\\outgoing-supplier-order";
            if (!MessageQueue.Exists(address))
            {
                MessageQueue.Create(address);
            }
            _queue = new MessageQueue(address);
            _queue.Purge();
            _cancellationTokenSource = new CancellationTokenSource();
            Task.Factory.StartNew(() => Listen(_cancellationTokenSource.Token), _cancellationTokenSource.Token);
        }

        [AfterScenario("msmqStub")]
        public void Stop()
        {
            _cancellationTokenSource.Cancel();
            _queue.Purge();
            _queue.Close();
            _queue.Dispose();
        }

        private void Listen(CancellationToken cancellationToken)
        {
            _isListening = true;
            while (_isListening)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    _isListening = false;
                    cancellationToken.ThrowIfCancellationRequested();
                }
                Receive();
                Thread.Sleep(100);
            }
        }

        private void Receive()
        {
            var message = _queue.Receive();
            MessageCount++;
            using (var reader = new StreamReader(message.BodyStream))
            {
                var json = reader.ReadToEnd();
                dynamic orderRequest = JObject.Parse(json);
                LastOrderRequest = new
                {
                    FromAddress = orderRequest.CustomerId,
                    ProductCode = orderRequest.ProductCode
                };
            }
        }
    }
}
