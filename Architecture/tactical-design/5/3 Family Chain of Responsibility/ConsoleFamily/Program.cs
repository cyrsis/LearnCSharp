using System;

namespace ConsoleFamily
{
    class Program
    {
        static void Main(string[] args)
        {
            FamilyMember dad = 
                new FamilyMember(
                    new Bearded("Dad",
                        new Emotional("Dad", "hoho")));
            FamilyMember mom = 
                new FamilyMember(
                    new Hairy("Mom",
                        new Emotional("Mom", "hihi")));
            FamilyMember boy = 
                new FamilyMember(
                    new Emotional("Boy", "haha"));
            FamilyMember dog = 
                new FamilyMember(
                    new Emotional("Dog", "tail waving"));
            FamilyMember uncle =
                new FamilyMember(
                    new Bearded("Uncle",
                        new Hairy("Uncle")));
            FamilyMember granddad =
                new FamilyMember(
                    new Bearded("Granddad",
                        new Hairy("Granddad",
                            new Emotional("Granddad", "oyoyo"))));
            Family family = 
                new Family(
                    new FamilyMember[] { dad, mom, boy, dog, uncle, granddad });

            family.WinterBegins();
            family.SummerComes();
            Console.ReadLine();
        }
    }
}
