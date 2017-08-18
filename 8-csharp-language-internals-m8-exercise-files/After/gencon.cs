public class Bar<T> where T : IFoo, new()
{
  public void Foo()
  {
    T item = new T();
    item.Foo();
  }
}

public interface IFoo
{
  void Foo();
}