using System;
using System.Reflection;
using System.Reflection.Emit;

namespace csharp_clr
{
    public class EmitDynamicCode
    {
        public void GenerateCode()
        {
            MethodInfo methodInfo = typeof(Console).GetMethod("WriteLine",
                       new Type[] { typeof(string) });

            DynamicMethod method = new DynamicMethod(
                "HelloWorld", typeof(void), new Type[] { });

            ILGenerator il = method.GetILGenerator();
            il.Emit(OpCodes.Ldstr, "Hello, world");
            il.Emit(OpCodes.Call, methodInfo);
            il.Emit(OpCodes.Ret);

            Action action = (Action)method.CreateDelegate(typeof(Action));
            action();
        }
    }
}