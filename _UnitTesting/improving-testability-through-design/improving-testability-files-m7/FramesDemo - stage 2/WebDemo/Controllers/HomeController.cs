using Common;
using Models;
using System.Web.Mvc;
using WebDemo.Gateway;

namespace WebDemo.Controllers
{
    public class HomeController : Controller
    {

        private DataGateway gateway;

        public HomeController(DataGateway gateway)
        {
            this.gateway = gateway;
        }

        public ActionResult Index()
        {
            try
            {
                Frame frame = this.gateway.LoadFrame();
                return View(frame);
            }
            catch (DataNotAvailableException dataEx)
            {
                return View("DataNotAvailableExceptionView", dataEx);
            }
            catch (System.Exception ex)
            {
                return View("ExceptionView", ex);
            }
        }

    }
}
