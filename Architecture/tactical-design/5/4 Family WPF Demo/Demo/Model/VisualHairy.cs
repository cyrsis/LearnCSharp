using Common;

namespace Demo.Model
{
    public class VisualHairy: VisualElement, IHairy
    {

        public VisualHairy(int rowIndex, ChainElement next): base(rowIndex, 5, next)
        {
        }

        public void GrowHair()
        {
            base.DrawAlternateImage();
        }

        public void CutHair()
        {
            base.DrawBaseImage();
        }
    }
}
