using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Web.Mvc;

namespace CarRental.Web.Controllers
{
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
