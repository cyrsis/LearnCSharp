using Models;
using Models.Common;
using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {

            Frame frame = new Frame(new Size() { Length = 3.0M, Width = 4.0M });

            ICircle circle = TryAddCircle(frame, 1.5M, 2.0M, 1.1M);
            circle.Radius = 1.2M;
            TryAddCircle(frame, 1.5M, 2.0M, 1.2M);

            frame.Draw();

            Console.ReadLine();
        
        }

        private static ICircle TryAddCircle(Frame frame, decimal x, decimal y, decimal radius)
        {

            ICircle circle = new Circle()
            {
                X = x,
                Y = y,
                Radius = radius
            };

            if (frame.TryAddCircle(circle))
                Console.WriteLine("Added circle at ({0}, {1}) R{2}", x, y, radius);
            else
                Console.WriteLine("Could not add circle at ({0}, {1}) R{2}", x, y, radius);

            return circle;

        }
    }
}
