namespace Demo
{
    public class ManualToString
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}, HomeTown: {2}", Name, Age, HomeTown);
        }
    }
}
