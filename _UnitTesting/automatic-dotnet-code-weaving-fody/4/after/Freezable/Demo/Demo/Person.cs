namespace Demo
{
    public class Person : IFreezable
    {
        private bool _isFrozen;
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string CalculateFullName()
        {
            return FirstName + " " + LastName;
        }

        public void Freeze()
        {
            _isFrozen = true;
        }
    }
}