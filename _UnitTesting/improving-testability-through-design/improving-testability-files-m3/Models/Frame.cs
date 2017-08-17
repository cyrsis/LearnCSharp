using Models.Common;
using System;
using System.Collections.Generic;

namespace Models
{
    public class Frame
    {
        private decimal length;
        private decimal width;
        private ICollection<ICircle> circles = new HashSet<ICircle>();

        public Frame(Size size)
        {
            
            if (size.Length <= 0 || size.Width <= 0)
                throw new System.ArgumentException("Frame dimensions must be positive.", "size");
            
            this.length = size.Length;
            this.width = size.Width;

        }
        
        public decimal Length 
        {
            get
            {
                return this.length;
            }
            set
            {
                if (value <= 0)
                    throw new System.ArgumentException("Length must be positive.", "value");
                this.length = value;
            }
        }

        public decimal Width 
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value <= 0)
                    throw new System.ArgumentException("Width must be positive.", "value");
                this.width = value;
            }
        }

        public bool TryAddCircle(Common.ICircle circle)
        {

            if (circle == null)
                throw new System.ArgumentNullException("circle",
                    "Cannot add circle to frame: Circle reference is null.");

            if (this.circles.Contains(circle))
                return false;

            if (circle.X < circle.Radius ||
                circle.X > this.length - circle.Radius ||
                circle.Y < circle.Radius ||
                circle.Y > this.width - circle.Radius)
                return false;

            this.circles.Add(circle);
            return true;

        }

        public void Draw()
        {
            Console.WriteLine("Frame {0}x{1}", this.length, this.width);
            foreach (ICircle circle in this.circles)
                circle.Draw();
        }

        public int CirclesCount
        {
            get
            {
                return this.circles.Count;
            }
        }
    }
}
