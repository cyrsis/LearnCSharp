using Common;

namespace Demo.Model
{
    public class VisualEmotional: VisualElement, IEmotional
    {

        public VisualEmotional(int rowIndex, ChainElement next) : base(rowIndex, 1, next)
        {
        }

        public void BeHappy()
        {
            base.DrawAlternateImage();
        }

        public void BeContent()
        {
            base.DrawBaseImage();
        }
    }
}
