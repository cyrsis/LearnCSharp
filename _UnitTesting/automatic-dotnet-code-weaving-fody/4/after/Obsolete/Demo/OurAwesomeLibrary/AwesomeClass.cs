using System;

namespace OurAwesomeLibrary
{
    public class AwesomeClass
    {
        //[Obsolete("Do not use this... etc.")]
        public void Manual()
        {
        }

        //[ObsoleteEx(Message = "We are moving to a new API")]
        public void Auto()
        {
        }

        //[ObsoleteEx(Message = "We are moving to a new API",
        //    RemoveInVersion = "6.0.0",
        //    TreatAsErrorFromVersion = "3.0.0")]
        public void AutoSpecificVersions()
        {
        }

        [ObsoleteEx(Message = "We are moving to a new API",
            RemoveInVersion = "5.0.0",
            TreatAsErrorFromVersion = "3.0.0",
            Replacement = "NewApiMethod")]
        public void SuggestAnAlternativeReplacement()
        {
        }
    }
}