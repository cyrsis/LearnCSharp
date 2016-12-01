using System;
namespace Houses
{
    class Program
    {
        static void Main(string[] args)
        {

            LandOwner owner = 
                new LandOwner(
                    14,
                    new Painter[] 
                    {
                        new Painter("Joe", 4),
                        new Painter("Jill", 5),
                        new Painter("Buster", 3)
                    });

            owner.MaintainHouses();

            Console.WriteLine("Press ENTER to exit...");
            Console.ReadLine();

        }
    }
}
