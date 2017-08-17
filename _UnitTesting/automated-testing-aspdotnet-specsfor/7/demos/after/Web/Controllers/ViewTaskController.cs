using System;
using System.Web.Mvc;
using Web.Data;
using Web.Models;

namespace Web.Controllers
{
	public class ViewTaskController : Controller
	{
		private readonly AppDbContext _context;

		public ViewTaskController(AppDbContext context)
		{
			_context = context;
		}

		public ViewResult ViewTask(Guid id)
		{
			var task = _context.Tasks.Find(id);
			var model = new TaskDetailsViewModel
			{
				Id = task.Id,
				Title = task.Title,
				Description = task.Description
			};

			return View(model);
		}
	}
}