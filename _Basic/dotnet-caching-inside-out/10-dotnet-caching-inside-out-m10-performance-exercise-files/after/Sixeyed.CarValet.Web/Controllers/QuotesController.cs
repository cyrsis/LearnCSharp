using Sixeyed.CarValet.Web.ApiClient;
using Sixeyed.Core.Logging;
using System.Web.Mvc;
using System.Web.UI;

namespace Sixeyed.CarValet.Web.Controllers
{
    public class QuotesController : Controller
    {
        [OutputCache(CacheProfile="LongLived")]
        public ActionResult GetQuotes()
        {
            Log.Debug("QuotesController.GetQuotes called");
            return View();
        }

        public ActionResult MyQuotes(int vehicleId)
        {
            Log.Debug("QuotesController.MyQuotes called");
            ViewData["vehicleId"] = vehicleId;
            return View();
        }

        public ActionResult GetQuotePrices(int vehicleId, string postalCode)
        {
            var quotes = QuotesClient.GetQuotes(vehicleId, postalCode);
            ViewData["vehicleId"] = vehicleId;
            ViewData["postalCode"] = postalCode;
            ViewData["Quotes"] = quotes;
            return View("MyQuotes");
        }
    }
}
