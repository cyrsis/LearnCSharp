using System;
using MediatR;
using Web.Data;

namespace Web.Commands
{
	public class EditTaskCommand : IRequest
	{
		public Guid Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
	}

	public class EditTaskCommandHandler : RequestHandler<EditTaskCommand>
	{
		private readonly ITaskRepository _tasks;

		public EditTaskCommandHandler(ITaskRepository tasks)
		{
			_tasks = tasks;
		}

		protected override void HandleCore(EditTaskCommand message)
		{
			var task = _tasks.FindById(message.Id);
			task.Title = message.Title;
			task.Description = message.Description;
			_tasks.SaveChanges();
		}
	}
}