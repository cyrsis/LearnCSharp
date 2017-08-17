using System.Linq;
using System.Web.Mvc;
using Web.Core;
using Web.Data;
using Web.Models;

namespace Web.Controllers
{
	public class HomeController : Controller
	{
		private readonly ITaskRepository _tasks;

		public HomeController(ITaskRepository tasks)
		{
			_tasks = tasks;
		}

		public ActionResult Index()
		{
			var models = _tasks.Query().Select(x => new TaskSummaryViewModel
			{
				Id = x.Id,
				Title = x.Title
			}).ToArray();

			return View(models);
		}
	}
}