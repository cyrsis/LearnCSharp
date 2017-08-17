using System;
using System.Web.Mvc;
using MediatR;
using Microsoft.Web.Mvc;
using Web.Commands;
using Web.Models;
using Web.Queries;

namespace Web.Controllers
{
	public class EditTaskController : Controller
	{
		private readonly IMediator _mediator;

		public EditTaskController(IMediator mediator)
		{
			_mediator = mediator;
		}

		public ViewResult Edit(Guid id)
		{
			var task = _mediator.Send(new GetTaskQuery {Id = id});
			var model = new EditTaskForm
			{
				Id = task.Id,
				Title = task.Title,
				Description = task.Description
			};

			return View(model);
		}

		[HttpPost]
		public ActionResult Edit(EditTaskForm form)
		{
			_mediator.Send(new EditTaskCommand
			{
				Id = form.Id,
				Title = form.Title,
				Description = form.Description
			});

			return this.RedirectToAction<ViewTaskController>(
				c => c.ViewTask(form.Id));
		}
	}
}