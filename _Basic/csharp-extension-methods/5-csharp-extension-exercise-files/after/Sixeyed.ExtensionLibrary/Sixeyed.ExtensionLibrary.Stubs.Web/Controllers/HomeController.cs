using Sixeyed.ExtensionLibrary.Stubs.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sixeyed.ExtensionLibrary.Stubs.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new UserModel());
        }

        public ActionResult Submit(UserModel user)
        {
            return View("Confirm", user);
        }
    }
}