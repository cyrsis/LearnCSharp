namespace Demo
{
    public class Person
    {
        public string Name;
        public int Age;
        public string HomeTown;
        public string Password;


        #region
        private string PrivateFieldsNotChanged;

        public string publicFieldsStartingLowerCase;
        
        public static string OnlyInstanceFieldsChangedNotStatics;
        #endregion

    }
}
