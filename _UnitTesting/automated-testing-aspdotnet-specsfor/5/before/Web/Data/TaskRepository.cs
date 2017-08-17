using System;
using System.Collections.Generic;
using System.Linq;
using Web.Core;

namespace Web.Data
{
	public interface ITaskRepository
	{
		IQueryable<Task> Query();
		void Add(Task task);
		Task FindById(Guid id);
		void SaveChanges();
	}

	public class TaskRepository : ITaskRepository
	{
		private static readonly Dictionary<Guid, Task> FakeDatabase;
		//For demonstration only!  Do NOT do this in production! :)
		static TaskRepository()
		{
			FakeDatabase = new Dictionary<Guid, Task>();

			var task = new Task
			{
				Id = Guid.NewGuid(), 
				Title = "Wash the car!", 
				Description = "Your car is disgusting.  Wash it!"
			};
			FakeDatabase.Add(task.Id, task);
			
			task = new Task
			{
				Id = Guid.NewGuid(), 
				Title = "Feed the dog!", 
				Description = "The dog is hungry.  Feed him 2 bowls!"
			};
			FakeDatabase.Add(task.Id, task);

			task = new Task
			{
				Id = Guid.NewGuid(), 
				Title = "Make a Pluralsight course!", 
				Description = "Courses are fun!  You should make one!"
			};
			FakeDatabase.Add(task.Id, task);
		}

		public IQueryable<Task> Query()
		{
			return FakeDatabase.Values.AsQueryable();
		}

		public void Add(Task task)
		{
			FakeDatabase.Add(task.Id, task);
		}

		public Task FindById(Guid id)
		{
			return FakeDatabase[id];
		}

		public void SaveChanges()
		{
			//TODO: If this was a real repository, it would actually do stuff.
		}
	}
}