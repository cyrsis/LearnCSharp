namespace Demo
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
        public string Password { get; set; }


        #region
        private string PrivateFieldsNotChanged;

        public string publicFieldsStartingLowerCase;
        
        public static string OnlyInstanceFieldsChangedNotStatics;
        #endregion

    }
}
