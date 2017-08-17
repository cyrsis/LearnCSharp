using Models;
using System.Web;
using System.Web.Mvc;

namespace WebDemo.Models
{
    public static class FrameToSvgHtmlExtension
    {

        public static IHtmlString Svg(this HtmlHelper htmlHelper, Frame frame, decimal padding)
        {
            return new HtmlString(ConvertToSvg(frame, padding));
        }

        public static void RenderSvg(this HtmlHelper htmlHelper, Frame frame, decimal padding)
        {
            htmlHelper.ViewContext.Writer.WriteLine("{0}", ConvertToSvg(frame, padding));
        }

        private static string ConvertToSvg(Frame frame, decimal padding)
        {
            FrameToSvg converter = new FrameToSvg();
            return converter.Convert(frame, padding);
        }

    }
}