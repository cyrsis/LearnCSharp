class Program
{
    static void Main(string[] args)
    {
        var v1 = new Vector(1, 2, 3);
        var v2 = new Vector(4, 5, 6);
        var v3 = new Vector(7, 8, 9);

        var x = Add(1, 2);
        var y = Add("Hello, ", "World");

        var v = Add(v1, v2);
        var w = Add(v2, v3);
    }

    static dynamic Add(dynamic a, dynamic b)
    {
        return a + b;
    }
}

class Vector
{
    public Vector(int x, int y, int z)
    {
        X = x; Y = y; Z = z;
    }

    public int X { get; private set; }
    public int Y { get; private set; }
    public int Z { get; private set; }

    public static Vector operator +(Vector v1, Vector v2)
    {
        return new Vector(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
    }

    public override string ToString()
    {
        return string.Format("({0}, {1}, {2})", X, Y, Z);
    }
}
