using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sixeyed.CarValet.Web.ApiClient;

namespace Sixeyed.CarValet.Web.Controllers
{
    public class QuotesController : Controller
    {
        public ActionResult GetQuotes()
        {
            return View();
        }

        public ActionResult MyQuotes(int vehicleId)
        {
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
