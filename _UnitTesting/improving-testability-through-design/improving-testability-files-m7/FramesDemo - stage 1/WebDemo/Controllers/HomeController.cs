using Models;
using Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace WebDemo.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Image(int stage)
        {

            Frame frame = LoadModel(stage);
            return FrameToSvg(frame);

        }

        private static ActionResult FrameToSvg(Frame frame)
        {
            return new ContentResult()
            {
                ContentType = "image/svg+xml",
                ContentEncoding = Encoding.UTF8,
                Content = new FrameToSvg().Convert(frame, 10)
            };
        }

        private Frame LoadModel(int stage)
        {
            IEnumerable<ICircle> circles = new List<ICircle>()
            {
                new Circle(new Location(182, 206), 42),
                new Circle(new Location(116, 160), 27),
                new Circle(new Location(187, 116), 31),
                new Circle(new Location(242, 155), 27),
                new Circle(new Location(240, 261), 27),
                new Circle(new Location(126, 267), 27),
                new Circle(new Location(93, 104), 22),
                new Circle(new Location(268, 102), 22),
                new Circle(new Location(252, 316), 22),
                new Circle(new Location(96, 315), 22),
                new Circle(new Location(101, 60), 14),
                new Circle(new Location(252, 64), 14),
                new Circle(new Location(245, 357), 14),
                new Circle(new Location(66, 346), 14)
            };

            Frame frame = new Frame(new Size(350, 410));

            foreach (ICircle circle in circles.Take(stage))
                frame = frame.Add(circle);
            
            return frame;

        }

    }
}
