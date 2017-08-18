using System.Reflection;

namespace System.Linq.Expressions
{
    public static class LambdaExpressionExtensions
    {
        public static PropertyInfo ToPropertyInfo(this LambdaExpression expression)
        {
            var memberExpression = expression.Body as MemberExpression;
            return memberExpression.Member as PropertyInfo;
        }
    }
}
