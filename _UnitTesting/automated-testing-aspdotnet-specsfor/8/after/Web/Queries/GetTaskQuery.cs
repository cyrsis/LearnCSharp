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
		private readonly AppDbContext _context;

		public GetTaskQueryHandler(AppDbContext context)
		{
			_context = context;
		}

		public Task Handle(GetTaskQuery message)
		{
			return _context.Tasks.Find(message.Id);
		}
	}
}