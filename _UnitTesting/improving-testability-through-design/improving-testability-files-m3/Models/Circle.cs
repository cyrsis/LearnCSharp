using Models.Common;
using System;

namespace Models
{
    public class Circle: ICircle
    {
        public decimal X { get; set; }
        public decimal Y { get; set; }
        public decimal Radius { get; set; }

        public bool Equals(ICircle other)
        {
            return other != null && other.X == this.X && 
                   other.Y == this.Y && other.Radius == this.Radius;
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as ICircle);
        }

        public override int GetHashCode()
        {
            return this.X.GetHashCode() ^ this.Y.GetHashCode() ^ this.Radius.GetHashCode();
        }

        public void Draw()
        {
            Console.WriteLine("Circle({0}, {1}, R{2})", this.X, this.Y, this.Radius);
        }
    }
}
