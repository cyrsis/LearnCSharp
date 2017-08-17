namespace Demo
{
    public class SomeClass
    {
        public void ManualUsing()
        {
            using (var o = new Location())
            {
                o.Altitude = 2;
            }
        }

        public void AutoUsing()
        {
            var o = new Location();

            o.Altitude = 2;
        }
    }
}
