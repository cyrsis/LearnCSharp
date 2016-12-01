using Common;

namespace Demo.Model
{
    public class VisualBearded: VisualElement, IBearded
    {

        public VisualBearded(int rowIndex, ChainElement next) : base(rowIndex, 3, next)
        {
        }

        public void GrowBeard()
        {
            base.DrawAlternateImage();
        }

        public void Shave()
        {
            base.DrawBaseImage();
        }
    }
}
