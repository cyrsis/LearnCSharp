using Models.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class FrameToSvg: IShapeVisitor
    {

        private decimal padding;
        private string header;
        private string framePart;
        private List<string> circleParts;

        public string Convert(Frame frame, decimal padding)
        {
            
            if (frame == null)
                throw new ArgumentNullException("frame", "Error converting to SVG: Frame is null.");

            Initialize(padding);
            frame.Accept(this);
            return Combine();
        
        }

        private void Initialize(decimal padding)
        {
            this.padding = padding;
            this.header = null;
            this.framePart = null;
            this.circleParts = new List<string>();
        }

        private string Combine()
        {
            return
                this.header
                + this.framePart
                + string.Join("", this.circleParts.ToArray())
                + "\n</svg>";
        }

        public void VisitRectangle(Rectangle rect)
        {

            this.header =
                string.Format("<svg xmlns=\"http://www.w3.org/2000/svg\" version=\"1.1\" width=\"100%\" height=\"100%\" viewBox=\"0 0 {0} {1}\" >",
                              this.padding * 2 + rect.Right,
                              this.padding * 2 + rect.Bottom);

            this.framePart =
                string.Format("\n    <rect x=\"{0}\" y=\"{1}\" width=\"{2}\" height=\"{3}\" fill=\"rgb(231, 238, 255)\" stroke-width=\"3\" stroke=\"rgb(52, 75, 248)\" />",
                              this.padding + rect.Left, this.padding + rect.Top,
                              rect.Length, rect.Width);
        
        }

        public void VisitCircle(Location center, decimal radius)
        {
            this.circleParts.Add(
                string.Format("\n    <circle cx=\"{0}\" cy=\"{1}\" r=\"{2}\" stroke=\"rgb(255, 192, 0)\" stroke-width=\"3\" fill=\"rgb(253, 247, 131)\" />",
                              center.X + this.padding, center.Y + this.padding, radius));
        }

    }
}