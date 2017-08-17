using System;
using System.Web.Mvc;
using Web.Data;
using Web.Models;

namespace Web.Controllers
{
	public class ViewTaskController : Controller
	{
		private readonly ITaskRepository _tasks;

		public ViewTaskController(ITaskRepository tasks)
		{
			_tasks = tasks;
		}

		public ViewResult ViewTask(Guid id)
		{
			var task = _tasks.FindById(id);
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