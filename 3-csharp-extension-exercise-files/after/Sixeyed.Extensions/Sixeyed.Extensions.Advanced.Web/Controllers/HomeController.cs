using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Recaptcha;

namespace Sixeyed.Extensions.Advanced.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [RecaptchaControlMvc.CaptchaValidator]
        public ActionResult Submit(bool captchaValid)
        {
            if (!captchaValid)
            {
                ModelState.AddModelError("", "reCAPTCHA invalid");
            }
            if (ModelState.IsValid)
            {
                return View("ThankYou");
            }
            return View("Index");
        }
    }
}