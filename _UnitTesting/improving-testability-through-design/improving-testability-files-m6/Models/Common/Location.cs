namespace Models.Common
{
    public struct Location
    {

        private readonly decimal x;
        private readonly decimal y;

        public Location(decimal x, decimal y)
        {
            this.x = x;
            this.y = y;
        }

        public decimal X { get { return this.x; } }

        public decimal Y { get { return this.y; } }

    }
}
