using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Domain;
using Web.Filters;
using Web.Models;
using Microsoft.Web.Mvc;

namespace Web.Controllers
{
	public class HomeController : Controller
	{
		private readonly ICurrentUser _currentUser;

		public HomeController(ICurrentUser currentUser)
		{
			_currentUser = currentUser;
		}

		public ActionResult Index()
		{
			ViewBag.Message = string.Format("Hello, {0}!", _currentUser.UserName);

			return View();
		}

		public ActionResult SetName()
		{
			return View();
		}

		[HttpPost]
		public ActionResult SetName(string name)
		{
			if (string.IsNullOrEmpty(name))
			{
				ViewBag.Error = "You must specify a name!";
				return View();
			}

			_currentUser.SetName(name);

			return RedirectToAction("Index");
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
			return this.RedirectToAction(c => c.SayHello(form.Name));
		}

		[MattOnly]
		public ActionResult ForMattOnly()
		{
			return View();
		}
	}
}