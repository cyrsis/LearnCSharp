using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Web.Core;
using Web.Data;

namespace Web.Controllers
{
	public class TasksController : ApiController
	{
		private readonly AppDbContext _context;

		public TasksController(AppDbContext context)
		{
			_context = context;
		}

		// GET: api/Tasks
		public IEnumerable<Task> Get()
		{
			return _context.Tasks.ToArray();
		}

		// GET: api/Tasks/{guid}
		public Task Get(Guid id)
		{
			return _context.Tasks.SingleOrDefault(x => x.Id == id);
		}

		// POST: api/Tasks
		public HttpResponseMessage Post([FromBody]Task task)
		{
			task.Id = task.Id == Guid.Empty ? Guid.NewGuid() : task.Id;

			_context.Tasks.Add(task);
			_context.SaveChanges();

			return Request.CreateResponse(HttpStatusCode.Created, task);
		}

		// PUT: api/Tasks/{guid}
		public HttpResponseMessage Put(Guid id, [FromBody]Task task)
		{
			var target = _context.Tasks.SingleOrDefault(x => x.Id == id);

			if (target == null) return Request.CreateResponse(HttpStatusCode.NotFound);

			target.Title = task.Title;
			target.Description = task.Description;
			target.AssignTo = task.AssignTo;

			_context.SaveChanges();

			return Request.CreateResponse(HttpStatusCode.OK);
		}

		// DELETE: api/Tasks/{guid}
		public HttpResponseMessage Delete(Guid id)
		{
			var target = _context.Tasks.SingleOrDefault(x => x.Id == id);

			if (target == null) return Request.CreateResponse(HttpStatusCode.NotFound);

			_context.Tasks.Remove(target);

			_context.SaveChanges();

			return Request.CreateResponse(HttpStatusCode.OK);
		}
	}
}
