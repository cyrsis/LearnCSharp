namespace Models.Common
{
    public struct Size
    {
        private readonly decimal length;
        private readonly decimal width;

        public Size(decimal length, decimal width)
        {
            this.length = length;
            this.width = width;
        }

        public decimal Length { get { return this.length; } }

        public decimal Width { get { return this.width; } }

    }
}