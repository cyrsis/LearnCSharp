using System;
using System.Linq;
using SpecsFor;
using SpecsFor.Configuration;
using Web.Core;
using Web.Data;

namespace Pluralsight.SpecsForCourse.Module5Sample.Specs.TestHelpers
{
	public interface IHaveDummyData : ISpecs
	{
		Task[] DummyTasks { get; set; }
	}

	public class DummyDataProvider : Behavior<IHaveDummyData>
	{
		public override void Given(IHaveDummyData instance)
		{
			instance.DummyTasks = new[]
			{
				new Task {Id = Guid.NewGuid(), Title = "Task 0 Title", Description = "Task 0 Description"},
				new Task {Id = Guid.NewGuid(), Title = "Task 1 Title", Description = "Task 1 Description"},
				new Task {Id = Guid.NewGuid(), Title = "Task 2 Title", Description = "Task 2 Description"},
				new Task {Id = Guid.NewGuid(), Title = "Task 3 Title", Description = "Task 3 Description"},
				new Task {Id = Guid.NewGuid(), Title = "Task 4 Title", Description = "Task 4 Description"},
			};

			instance.GetMockFor<ITaskRepository>()
				.Setup(r => r.Query())
				.Returns(() => instance.DummyTasks.AsQueryable());
		}
	}
}