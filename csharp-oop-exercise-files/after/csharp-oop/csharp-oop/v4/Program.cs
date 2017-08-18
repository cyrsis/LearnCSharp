namespace csharp_oop.v4
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;

    namespace csharp_oop
    {
        public class StockQuote
        {
            public DateTime Date { get; set; }
            public decimal Open { get; set; }
            public decimal High { get; set; }
            public decimal Low { get; set; }
            public decimal Close { get; set; }

            public bool ReversesDownFrom(StockQuote otherQuote)
            {
                return Open > otherQuote.High && Close < otherQuote.Low;
            }

            public bool ReversesUpFrom(StockQuote otherQuote)
            {
                return Open < otherQuote.Low && Close > otherQuote.High;
            }
        }

        public interface IDataLoader
        {
            string LoadData();
        }

        public class FileLoader : IDataLoader
        {
            private readonly string _fileName;

            public FileLoader(string fileName)
            {
                _fileName = fileName;
            }


            public string LoadData()
            {
                return File.ReadAllText(_fileName);
            }
        }

        public class WebLoader : IDataLoader
        {
            private readonly string _url;

            public WebLoader(string url)
            {
                _url = url;
            }

            public string LoadData()
            {
                var client = new WebClient();
                return client.DownloadString(new Uri(_url));
            }
        }

        public class StockQuoteCsvParser
        {
            IDataLoader _loader;

            public StockQuoteCsvParser(string source)
            {                
                if (source.ToLower().StartsWith("http"))
                {
                    _loader = new WebLoader(source);
                }
                else
                {
                    _loader = new FileLoader(source);
                }                                                 
            }

            public IEnumerable<StockQuote> Load()
            {
                var csvData = _loader.LoadData().Split('\n');

                return
                        from line in csvData.Skip(1) 
                        let data = line.Split(',')
                        select new StockQuote()
                        {
                            Date = DateTime.Parse(data[0]),
                            Open = decimal.Parse(data[1]),
                            High = decimal.Parse(data[2]),
                            Low = decimal.Parse(data[3]),
                            Close = decimal.Parse(data[4])
                        };
            }
        }

        public enum ReversalDirection
        {
            Up,
            Down
        }

        public class Reversal
        {
            public Reversal(StockQuote quote, ReversalDirection direction)
            {
                StockQuote = quote;
                Direction = direction;
            }
            public ReversalDirection Direction { get; set; }
            public StockQuote StockQuote { get; set; }
        }

        public class ReversalLocator
        {
            private readonly IList<StockQuote> _quotes;

            public ReversalLocator(IList<StockQuote> quotes)
            {
                _quotes = quotes;
            }

            public IEnumerable<Reversal> Locate()
            {
                for (int i = 0; i < _quotes.Count - 1; i++)
                {
                    if (_quotes[i].ReversesDownFrom(_quotes[i + 1]))
                    {
                        yield return new Reversal(_quotes[i], ReversalDirection.Down);
                    }
                    if (_quotes[i].ReversesUpFrom(_quotes[i + 1]))
                    {
                        yield return new Reversal(_quotes[i], ReversalDirection.Up);
                    }
                }
            }
        }

        class StockQuoteAnalyzer
        {
            private readonly StockQuoteCsvParser _parser;
            private readonly List<StockQuote> _quotes;

            public StockQuoteAnalyzer(string urlOrFilename)
            {
                _parser = new StockQuoteCsvParser(urlOrFilename);
                _quotes = _parser.Load().ToList();
            }

            public IEnumerable<Reversal> FindReversals()
            {
                var locator = new ReversalLocator(_quotes);
                return locator.Locate();
            }
        }

        class Program
        {
            static void Main2(string[] args)
            {
                var analyzer = new StockQuoteAnalyzer(args[0]);
                foreach (var reversal in analyzer.FindReversals())
                {
                    PrintReversal(reversal);
                }
            }

            private static void PrintReversal(Reversal reversal)
            {
                if (reversal.Direction == ReversalDirection.Up)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Reversed up on " + reversal.StockQuote.Date);
                }
                else if (reversal.Direction == ReversalDirection.Down)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Reversed down on " + reversal.StockQuote.Date);
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }

}