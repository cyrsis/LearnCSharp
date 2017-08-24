using Microsoft.AspNetCore.Mvc;

namespace Cubo.Api.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}