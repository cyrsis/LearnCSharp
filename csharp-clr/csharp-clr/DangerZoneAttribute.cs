using System;

namespace csharp_clr
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class)]
    public class DangerZoneAttribute : Attribute
    {
        public DangerZoneAttribute(int min, int max)
        {
            Minimum = min;
            Maximum = max;
            Message = "";
        }

        public int Minimum { get; set; }
        public int Maximum { get; set; }
        public string Message { get; set; }
    }

    [DangerZone(12, 18, Message = "Danger!")]
    public class Human
    {

        public int Age { get; set; }
    }

}