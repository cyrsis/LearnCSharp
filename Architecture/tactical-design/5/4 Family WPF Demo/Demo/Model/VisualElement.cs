using Common;
using System.Drawing;
using System.IO;
using System.Reflection;

namespace Demo.Model
{
    public class VisualElement: ChainElement
    {

        public static readonly VisualElement NullObject = new NullVisualElement();

        private int rowIndex;
        private int columnIndex;
        private int columnOffset;

        public VisualElement(int rowIndex, int columnIndex, ChainElement next): base(next)
        {
            this.rowIndex = rowIndex;
            this.columnIndex = columnIndex;
        }

        protected VisualElement() { }

        public Bitmap ToBitmap()
        {
            Bitmap bitmap = new Bitmap(ImageGrid.CellDimension, ImageGrid.CellDimension);
            DrawOn(bitmap);
            return bitmap;
        }

        protected virtual void DrawOn(Image bmp)
        {

            ImageGrid grid = new ImageGrid();
            grid.DrawCell(bmp, rowIndex, columnIndex + columnOffset);

            base.Forward<VisualElement>(VisualElement.NullObject).DrawOn(bmp);

        }

        protected void DrawBaseImage()
        {
            this.columnOffset = 0;
        }

        protected void DrawAlternateImage()
        {
            this.columnOffset = 1;
        }

    }

    class NullVisualElement : VisualElement
    {
        protected override void DrawOn(Image bmp) { }
    }

}
