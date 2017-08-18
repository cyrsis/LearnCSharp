using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

class Program
{
    static Foo _foo;

    static void Main()
    {
        _foo = new Foo();

        var bar1 = new Bar();
        _foo.SetProperty("Bar", bar1);

        var bar2 = _foo.GetProperty<Bar>("Bar");

        _foo = null;
        bar1 = null;
        bar2 = null;

        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.ReadLine();
    }
}

class Foo
{
    ~Foo()
    {
        Console.WriteLine("Foo collected");
    }
}

class Bar
{
    ~Bar()
    {
        Console.WriteLine("Bar collected");
    }
}

static class ExtensionProperties
{
    private static ConditionalWeakTable<object, ConcurrentDictionary<string, object>> _properties = new ConditionalWeakTable<object, ConcurrentDictionary<string, object>>();

    public static V GetProperty<V>(this object key, string name)
    {
        return (V)GetProperties(key)[name];
    }

    public static void SetProperty<V>(this object key, string name, V value)
    {
        GetProperties(key)[name] = value;
    }

    private static ConcurrentDictionary<string, object> GetProperties(object key)
    {
        return _properties.GetOrCreateValue(key);
    }
}
