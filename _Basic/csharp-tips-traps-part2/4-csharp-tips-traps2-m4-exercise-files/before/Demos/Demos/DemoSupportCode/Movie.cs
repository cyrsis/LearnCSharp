namespace Demos.DemoSupportCode
{
    class Movie : IExtraDebuggable
    {
        public string DebugInfo
        {
            get { return "Hi, I'm a movie"; }
        }
    }
}