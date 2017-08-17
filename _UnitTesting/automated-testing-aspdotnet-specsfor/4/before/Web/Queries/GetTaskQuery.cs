using System;
using MediatR;
using Web.Core;
using Web.Data;

namespace Web.Queries
{
	public class GetTaskQuery : IRequest<Task>
	{
		public Guid Id { get; set; }
	}

	public class GetTaskQueryHandler : IRequestHandler<GetTaskQuery, Task>
	{
		private readonly ITaskRepository _tasks;

		public GetTaskQueryHandler(ITaskRepository tasks)
		{
			_tasks = tasks;
		}

		public Task Handle(GetTaskQuery message)
		{
			return _tasks.FindById(message.Id);
		}
	}
}