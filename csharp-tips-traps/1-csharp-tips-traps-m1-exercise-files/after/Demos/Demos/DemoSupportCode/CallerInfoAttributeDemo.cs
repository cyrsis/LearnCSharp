using System.Runtime.CompilerServices;

namespace Demos.DemoSupportCode
{
    class CallerInfoAttributeDemo
    {
        public string WhoCalledMe([CallerMemberName] string callingMember = null)
        {
            return "I was called from member " + callingMember;
        }


        public string WhatFileCalledMe([CallerFilePath] string callingFile = null)
        {
            return "I was called from file " + callingFile;
        }


        public string WhatLineCalledMe([CallerLineNumber] int callingLineNum = 0)
        {
            return "I was called from line " + callingLineNum ;
        }
    }
}
