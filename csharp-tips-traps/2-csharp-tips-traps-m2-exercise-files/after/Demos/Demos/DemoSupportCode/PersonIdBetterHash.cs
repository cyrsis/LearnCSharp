namespace Demos.DemoSupportCode
{
    internal class PersonIdBetterHash
    {
        public PersonIdBetterHash(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        // Equals override omitted
    }
}