﻿using System.Web.Mvc;
using System.Web.Security;
using Microsoft.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
	[AllowAnonymous]
	public class AuthenticationController : Controller
	{
		public ViewResult LogOn()
		{
			return View();
		}

		[HttpPost]
		public ActionResult LogOn(LogOnForm form)
		{
			if (form.Username == "Matt" && form.Password == "Password1")
			{
				FormsAuthentication.SetAuthCookie(form.Username, false);
				return this.RedirectToAction<HomeController>(c => c.Index());
			}

			ModelState.AddModelError("", "Username or password is invalid.");
			return View();
		}
	}
}