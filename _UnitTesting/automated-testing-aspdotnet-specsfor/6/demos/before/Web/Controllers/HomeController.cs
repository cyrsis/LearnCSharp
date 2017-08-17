using System.Linq;
using System.Web.Mvc;
using Web.Core;
using Web.Data;
using Web.Models;

namespace Web.Controllers
{
	public class HomeController : Controller
	{
		private readonly AppDbContext _context;

		public HomeController(AppDbContext context)
		{
			_context = context;
		}

		public ActionResult Index()
		{
			var models = _context.Tasks.Select(x => new TaskSummaryViewModel
			{
				Id = x.Id,
				Title = x.Title
			}).ToArray();

			return View(models);
		}
	}
}