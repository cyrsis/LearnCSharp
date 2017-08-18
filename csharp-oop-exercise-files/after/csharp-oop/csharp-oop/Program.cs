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

    public interface IStockQuoteParser
    {
        IList<StockQuote> ParseQuotes();
    }

    public class StockQuoteCsvParser : IStockQuoteParser
    {
        private readonly IDataLoader _loader;

        public StockQuoteCsvParser(IDataLoader loader)
        {
            _loader = loader;
        }

        public IList<StockQuote> ParseQuotes()
        {
            var csvData = _loader.LoadData().Split('\n');

            return (
               from line in csvData.Skip(1)
               let data = line.Split(',')
               select new StockQuote()
               {
                   Date = DateTime.Parse(data[0]),
                   Open = decimal.Parse(data[1]),
                   High = decimal.Parse(data[2]),
                   Low = decimal.Parse(data[3]),
                   Close = decimal.Parse(data[4])
               }).ToList();
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
        private readonly IStockQuoteParser _parser;

        public StockQuoteAnalyzer(IStockQuoteParser parser)
        {
            _parser = parser;
        }

        public IEnumerable<Reversal> FindReversals()
        {
            var quotes = _parser.ParseQuotes();
            var locator = new ReversalLocator(quotes);
            return locator.Locate();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // set the scene ...
            var loader = GetLoaderFor(args[0]);
            var parser = new StockQuoteCsvParser(loader);
            var analyzer = new StockQuoteAnalyzer(parser);

            // ... action!!!
            foreach (var reversal in analyzer.FindReversals())
            {
                PrintReversal(reversal);
            }
        }

        private static IDataLoader GetLoaderFor(string source)
        {
            IDataLoader loader;
            if (source.ToLower().StartsWith("http"))
            {
                loader = new WebLoader(source);
            }
            else
            {
                loader = new FileLoader(source);
            }
            return loader;
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
