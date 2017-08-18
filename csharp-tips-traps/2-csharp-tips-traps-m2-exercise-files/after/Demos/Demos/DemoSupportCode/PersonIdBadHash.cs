namespace Demos.DemoSupportCode
{
    class PersonIdBadHash
    {        
        public int Id { get; set; }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        // Equals override omitted
    }
}