using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Demo.Model
{
    public class ImageComposer
    {

        private readonly int ImagesPerRow = 3;

        public Image Compose(IEnumerable<Image> cellImages)
        {
            Image image = InitializeImage(cellImages);
            return DrawAllCells(image, cellImages);
        }

        private Image InitializeImage(IEnumerable<Image> cellImages)
        {

            Size cellSize = CalculateCellSize(cellImages);
            Size imageSize = CalculateImageSize(cellImages, cellSize);

            return InitializeImage(imageSize);

        }

        private Image InitializeImage(Size imageSize)
        {
            Image image = new Bitmap(imageSize.Width, imageSize.Height);
            FillBackground(imageSize, image);
            return image;
        }

        private void FillBackground(Size imageSize, Image image)
        {
            using (Graphics gr = Graphics.FromImage(image))
            {
                gr.FillRectangle(Brushes.White, new Rectangle(new Point(), imageSize));
            }
        }

        private Size CalculateCellSize(IEnumerable<Image> cellImages)
        {
            int maxWidth = cellImages.Select(img => img.Width).DefaultIfEmpty<int>().Max();
            int maxHeight = cellImages.Select(img => img.Height).DefaultIfEmpty<int>().Max();
            return new Size(maxWidth, maxHeight);
        }

        private Size CalculateImageSize(IEnumerable<Image> cellImages, Size cellSize)
        {

            int rowsCount = (cellImages.Count() + ImagesPerRow - 1) / ImagesPerRow;

            int columnsCount = cellImages.Count();
            if (columnsCount >= ImagesPerRow)
                columnsCount = ImagesPerRow;

            int width = cellSize.Width * columnsCount;
            int height = cellSize.Height * rowsCount;

            if (width == 0)
                width = 1;

            if (height == 0)
                height = 1;

            return new Size(width, height);

        }

        private Image DrawAllCells(Image destImage, IEnumerable<Image> cellImages)
        {
            using (Graphics gr = Graphics.FromImage(destImage))
            {
                DrawAllCells(gr, cellImages);
            }
            return destImage;
        }

        private void DrawAllCells(Graphics gr, IEnumerable<Image> cellImages)
        {

            Size cellSize = CalculateCellSize(cellImages);
            int index = 0;
            
            foreach (Image member in cellImages)
                DrawCell(gr, cellSize, member, index++);
        
        }

        private void DrawCell(Graphics gr, Size cellSize, Image member, int index)
        {
            Point imagePos = GetImagePosition(cellSize, index);
            gr.DrawImage(member, imagePos);
        }

        private Point GetImagePosition(Size cellSize, int index)
        {

            int row = index / ImagesPerRow;
            int col = index % ImagesPerRow;

            int x = col * cellSize.Width;
            int y = row * cellSize.Height;

            return new Point(x, y);

        }

    }
}