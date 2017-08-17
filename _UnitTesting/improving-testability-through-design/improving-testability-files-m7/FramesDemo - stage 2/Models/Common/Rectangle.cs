namespace Models.Common
{
    public struct Rectangle
    {
        private readonly Location location;
        private readonly Size size;

        public Rectangle(Location location, Size size)
        {
            this.location = location;
            this.size = size;
        }

        public decimal Left { get { return this.location.X; } }

        public decimal Right { get { return this.location.X + this.size.Length; } }

        public decimal Top { get { return this.location.Y; } }

        public decimal Bottom { get { return this.location.Y + this.size.Width; } }

        public decimal Length { get { return this.size.Length; } }

        public decimal Width { get { return this.size.Width; } }

    }
}
