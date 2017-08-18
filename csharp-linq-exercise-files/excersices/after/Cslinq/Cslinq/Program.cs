using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Extensions;
using System.Linq;


namespace Cslinq
{ 
    class Program
    {
        static void Main(string[] args)
        {

            MovieDB db = new MovieDB();

            IEnumerable<Movie> query =
                db.Movies.Where(m => m.Title.StartsWith("Star"))
                    .OrderBy(m => m.ReleaseDate.Year);

            var query2 =
                from m in db.Movies
                where m.Title.StartsWith("L")
                select m;

            foreach (var movie in query2)
            {
                Console.WriteLine(movie.Title);
            }
        }

        private static void QueryCities()
        {
            IEnumerable<string> cities = new[] {"Ghent", "London", "Las Vegas", "Hyderabad"};
           
            IEnumerable<string> query =
                cities.Where(city => city.StartsWith("L"))
                    .OrderByDescending(city => city.Length);

            foreach (var city in query)
            {
                Console.WriteLine(city);
            }
        }

        private static void WorkWithFuncs()
        {
            Expression<Func<int, int>> square = x => x*x;
            Func<int, int, int> add = (x, y) => x + y;
            Action<int> write = x => Console.WriteLine(x);
            
            //write(square(add(1,3)));
        }
    }
}

namespace Extensions
{
    public static class FilterExtensions
    {
        public static IEnumerable<T> Filter<T> (this IEnumerable<T> input,
            Func<T, bool> predicate)
        {
            foreach (var item in input)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }
    }    
}
