using System;
using System.Collections.Generic;

namespace Application
{

    interface IShapeVisitor
    {
        void VisitCircle(double radius);
        void VisitSquare(double side);
    }

    abstract class Shape
    {
        public abstract void Accept(IShapeVisitor visitor);
    }

    class Circle : Shape
    {
        private readonly double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override void Accept(IShapeVisitor visitor)
        {
            visitor.VisitCircle(this.radius);
        }
    }

    class Square : Shape
    {
        private readonly double side;

        public Square(double side)
        {
            this.side = side;
        }

        public override void Accept(IShapeVisitor visitor)
        {
            visitor.VisitSquare(this.side);
        }
    }

    interface IGraphics
    {
        void Draw(Shape shape);
    }

    class Graphics: IGraphics, IShapeVisitor
    {
        public void VisitCircle(double radius)
        {
            Console.WriteLine("Circle R{0}", radius);
        }

        public void VisitSquare(double side)
        {
            Console.WriteLine("Square A{0}", side);
        }

        public void Draw(Shape shape)
        {
            shape.Accept(this);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {

            IEnumerable<Shape> shapes = new List<Shape>()
            {
                new Circle(1.2),
                new Square(3.4)
            };

            IGraphics graphics = new Graphics();

            foreach (Shape shape in shapes)
                graphics.Draw(shape);

            Console.ReadLine();

        }
    }
}
