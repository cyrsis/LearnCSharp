using Papercut.SMTP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Sixeyed.SpecFlowItAll.AcceptanceTests.Stubs
{
    [Binding]
    public class SmtpStub
    {
        public static int EmailCount { get; private set; }

        public static dynamic LastOrderRequest { get; private set; }

        private Server _server;

        [BeforeScenario("smtpStub")]
        public void Start()
        {
            Processor.MessageReceived += Processor_MessageReceived;
            _server = new Server();
            _server.Bind("127.0.0.1", 25);
        }

        [AfterScenario("smtpStub")]
        public void Stop()
        {
            _server.Stop();
            Processor.MessageReceived -= Processor_MessageReceived;
        }

        void Processor_MessageReceived(object sender, MessageEventArgs e)
        {
            EmailCount++;

            var messageLines = File.ReadAllLines(e.Entry.File);
            var from = messageLines.Single(x => x.StartsWith("From:")).Replace("From: ", "");
            var to = messageLines.Single(x => x.StartsWith("To:")).Replace("To: ", "");
            var subject = messageLines.Single(x => x.StartsWith("Subject:")).Replace("Subject: ", "");

            LastOrderRequest = new
            {
                FromAddress = from,
                ToAddress = to,
                ProductCode = subject
            };
        }
    }
}
