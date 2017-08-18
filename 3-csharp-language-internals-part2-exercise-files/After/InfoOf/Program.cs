using System;
using System.Linq.Expressions;
using System.Reflection;

class Program
{
    static void Main()
    {
        var absMtd = Utils.InfoOf(() => Math.Abs(default(double)));
        var nowProp = Utils.InfoOf(() => DateTime.Now);
        var guidCtor = Utils.InfoOf(() => new Guid(default(byte[])));
    }
}

static class Utils
{
    public static MemberInfo InfoOf<T>(Expression<Func<T>> f)
    {
        return InfoOfCore(f);
    }

    public static MemberInfo InfoOf(Expression<Action> f)
    {
        return InfoOfCore(f);
    }

    private static MemberInfo InfoOfCore(LambdaExpression e)
    {
        switch (e.Body.NodeType)
        {
            case ExpressionType.New:
                return ((NewExpression)e.Body).Constructor;
            case ExpressionType.Call:
                return ((MethodCallExpression)e.Body).Method;
            case ExpressionType.MemberAccess:
                return ((MemberExpression)e.Body).Member;
            default:
                throw new NotSupportedException();
        }
    }
}