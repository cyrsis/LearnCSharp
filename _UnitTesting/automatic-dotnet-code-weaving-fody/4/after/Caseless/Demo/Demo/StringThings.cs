namespace Demo
{
    public static class StringThings
    {
        public static bool AreEqual(string s1, string s2)
        {
            return s1 == s2;

            // return string.Equals(s1, s2, StringComparison.OrdinalIgnoreCase);
        }

        public static bool NotEqual(string s1, string s2)
        {
            return s1 != s2;
        }

        public static bool Contains(string sentenceToSearch, string what)
        {
            return sentenceToSearch.Contains(what);
        }
    }
}