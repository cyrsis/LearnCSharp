using System;

namespace AllCodeRush.Code.LambdaExpressionsAnonymousMethods
{
  public abstract class BaseNameAnonymousMethod
  {
    protected abstract Func<int, int, int> GetOperation();
  }
}
