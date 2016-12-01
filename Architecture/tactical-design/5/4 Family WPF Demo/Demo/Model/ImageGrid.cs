using System;
using System.Drawing;
using System.IO;
using System.Reflection;

namespace Demo.Model
{
    public class ImageGrid
    {

        private static readonly int BorderWidth = 2;
        public static readonly int CellDimension = 297;

        private static Image grid;
        private static object gridLock = new object();

        private Size CellSize
        {
            get
            {
                return new Size(CellDimension, CellDimension);
            }
        }

        public void DrawCell(Image bmp, int rowIndex, int columnIndex)
        {

            Image image = LoadImage();

            using (Graphics gr = Graphics.FromImage(bmp))
            {
                CopyCell(gr, image, rowIndex, columnIndex);
            }

        }

        private static Image LoadImage()
        {

            lock (gridLock)
            {

                if (grid == null)
                {
                    Stream resource = Assembly.GetExecutingAssembly().GetManifestResourceStream("Demo.Data.Elements.png");
                    grid = Image.FromStream(resource);
                }

                return grid;

            }

        }

        private void CopyCell(Graphics gr, Image image, int row, int col)
        {
            Point srcPos = GetCellPos(row, col);
            CopyCell(gr, image, srcPos);
        }

        private Point GetCellPos(int row, int col)
        {
            int x = BorderWidth + col * (CellDimension + BorderWidth);
            int y = BorderWidth + row * (CellDimension + BorderWidth);
            return new Point(x, y);
        }

        private void CopyCell(Graphics gr, Image image, Point srcPos)
        {
            Rectangle destRect = new Rectangle(new Point(0, 0), this.CellSize);
            Rectangle srcRect = new Rectangle(srcPos, this.CellSize);
            gr.DrawImage(image, destRect, srcRect, GraphicsUnit.Pixel);
        }

    }
}
