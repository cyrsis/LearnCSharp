using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Message = "Hello, world!";

			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		public ActionResult SayHello(string name)
		{
			var model = new SayHelloViewModel
			{
				Name = name
			};

			return View(model);
		}

		[HttpPost]
		public ActionResult SayHello(SayHelloForm form)
		{
			return RedirectToAction("SayHello", new {name = form.Name});
		}
	}
}