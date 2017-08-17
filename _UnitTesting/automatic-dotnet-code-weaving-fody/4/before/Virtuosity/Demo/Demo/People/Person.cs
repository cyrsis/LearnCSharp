namespace Demo.People
{
    #region
    // [DoNotVirtualize] 
    #endregion
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string CalculateFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}