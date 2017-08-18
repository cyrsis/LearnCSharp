namespace Demos.DemoSupportCode
{
    internal class Paragraph
    {
        private int? _fontSize;

        public Page Parent { get; set; }

        public int FontSize
        {
            get
            {
                if (_fontSize == null)
                {
                    return Parent.FontSize;
                }

                return _fontSize.Value;

                // return _fontSize ?? Parent.FontSize;
            }
            set
            {
                var isNewSizeSameAsParents = value == Parent.FontSize;

                if (isNewSizeSameAsParents)
                {
                    _fontSize = null;
                }
                else
                {
                    _fontSize = value;
                }
            }
        }
    }
}