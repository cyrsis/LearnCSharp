namespace Demos.DemoSupportCode
{    
    class PersonWithoutDebuggerDisplay
    {
        public int AgeInYears { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return "This is overridden ToString()";
        }
    }
}
