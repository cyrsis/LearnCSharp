using System.Net.Mail;
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
			task.AssignTo = form.AssignTo;

			_context.Tasks.Add(task);
			_context.SaveChanges();

			if (!string.IsNullOrEmpty(task.AssignTo))
			{
				using (var client = new SmtpClient())
				{
					var message = new MailMessage(
						"no-reply@sample-course.com",
						task.AssignTo,
						"New Task Assignment!",
						"You have been assigned a new task: " + task.Title);
					client.Send(message);
				}
			}

			return this
				.RedirectToAction<ViewTaskController>(c => c.ViewTask(task.Id));
		}
	}
}