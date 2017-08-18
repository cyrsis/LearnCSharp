using System;
using System.Reflection;

namespace csharp_clr
{
    public class Reflection
    {
        public void Reflect()
        {
            var type = typeof(Program);
            var members = type.GetMembers(BindingFlags.Static |
                                          BindingFlags.Instance |
                                          BindingFlags.NonPublic |
                                          BindingFlags.Public);

            foreach (var memberInfo in members)
            {
                Console.WriteLine(memberInfo.Name);
            }
        }
    }
}