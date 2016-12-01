using Common;
// TextDemo/Program.cs
using System;

namespace TextDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            FamilyMember dad =
                new FamilyMember(
                    new Bearded("Dad",
                        new Emotional("Dad", "hoho", ChainElement.NullValue)));
            FamilyMember mom =
                new FamilyMember(
                    new Hairy("Mom",
                        new Emotional("Mom", "hihi", ChainElement.NullValue)));
            FamilyMember boy =
                new FamilyMember(
                    new Emotional("Boy", "haha", ChainElement.NullValue));
            FamilyMember dog =
                new FamilyMember(
                    new Emotional("Dog", "tail waving", ChainElement.NullValue));
            FamilyMember uncle =
                new FamilyMember(
                    new Bearded("Uncle",
                        new Hairy("Uncle", ChainElement.NullValue)));
            FamilyMember granddad =
                new FamilyMember(
                    new Bearded("Granddad",
                        new Hairy("Granddad",
                            new Emotional("Granddad", "oyoyo", ChainElement.NullValue))));

            Family family = new Family(new FamilyMember[] { dad, mom, boy, dog, uncle, granddad });

            family.WinterBegins();
            family.SummerComes();
            Console.ReadLine();

        }
    }
}
