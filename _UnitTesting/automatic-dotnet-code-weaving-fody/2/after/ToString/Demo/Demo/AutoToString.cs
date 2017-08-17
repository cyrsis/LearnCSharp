namespace Demo
{
    [ToString]
    public class AutoToString
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
        
       [IgnoreDuringToString]
        public string Password { get; set; }
    }
}
