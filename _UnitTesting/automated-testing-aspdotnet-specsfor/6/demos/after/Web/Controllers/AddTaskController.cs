using System.Web.Mvc;
using Microsoft.Web.Mvc;
using Web.Core;
using Web.Data;
using Web.Infrastructure;
using Web.Models;

namespace Web.Controllers
{
	public class AddTaskController : Controller
	{
		private readonly AppDbContext _context;
		private readonly IIdGenerator _idGenerator;

		public AddTaskController(AppDbContext context, IIdGenerator idGenerator)
		{
			_context = context;
			_idGenerator = idGenerator;
		}

		public ViewResult Add()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Add(AddTaskForm form)
		{
			var task = new Task();
			task.Id = _idGenerator.GetNewId();
			task.Title = form.Title;
			task.Description = form.Description;

			_context.Tasks.Add(task);
			_context.SaveChanges();

			return this
				.RedirectToAction<ViewTaskController>(c => c.ViewTask(task.Id));
		}
	}
}