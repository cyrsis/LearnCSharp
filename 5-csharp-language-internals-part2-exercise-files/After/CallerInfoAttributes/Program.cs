using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
        Who.AmI();
        var p = new Program();
        var q = -p;
        var ignored = p.Foo;
        p.Bar += () => { };
    }

    public Program()
    {
        Who.AmI();
    }

    public string Foo
    {
        get { Who.AmI(); return ""; }
    }

    public event Action Bar
    {
        add { Who.AmI(); }
        remove { Who.AmI(); }
    }

    public static Program operator -(Program p)
    {
        Who.AmI();
        return p;
    }

    ~Program()
    {
        Who.AmI();
    }
}

static class Who
{
    public static void AmI([CallerMemberName]string name = "")
    {
        Console.WriteLine(name);
    }
}

class Person : INotifyPropertyChanged
{
    private string name;

    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            SetProperty(ref name, value);
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void SetProperty<T>(ref T field, T value, [CallerMemberName]string name = "")
    {
        if (!EqualityComparer<T>.Default.Equals(field, value))
        {
            field = value;
            OnPropertyChanged(name);
        }
    }

    protected virtual void OnPropertyChanged(string name)
    {
        var pc = PropertyChanged;
        if (pc != null)
        {
            pc(this, new PropertyChangedEventArgs(name));
        }
    }
}