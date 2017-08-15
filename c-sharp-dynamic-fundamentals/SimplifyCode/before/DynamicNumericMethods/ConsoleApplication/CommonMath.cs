namespace ConsoleApplication
{
    static class CommonMath
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }
    }

    






    // Can't do this because no unified numeric types in C#
    //static class CommonMathGeneric
    //{
    //    public static T Add<T>(T a, T b) // can't say "where T is a numeric type"
    //    {
    //        return a + b;
    //    }        
    //}
}
