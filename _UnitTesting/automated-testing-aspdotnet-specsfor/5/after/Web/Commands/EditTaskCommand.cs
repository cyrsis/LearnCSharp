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
		private readonly AppDbContext _context;

		public EditTaskCommandHandler(AppDbContext context)
		{
			_context = context;
		}

		protected override void HandleCore(EditTaskCommand message)
		{
			var task = _context.Tasks.Find(message.Id);
			task.Title = message.Title;
			task.Description = message.Description;
			_context.SaveChanges();
		}
	}
}