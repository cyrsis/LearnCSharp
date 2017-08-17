using System;
using SpecsFor;
using Web.Core;
using Web.Data;

namespace Pluralsight.SpecsForCourse.Module4Sample.Specs.TestHelpers
{
	public abstract class SpecsForWithDummyData<TType> : SpecsFor<TType> 
		where TType : class
	{
		protected Task[] Tasks;

		protected override void Given()
		{
			Tasks = new[]
			{
				new Task {Id = Guid.NewGuid(), Title = "Task 0 Title", Description = "Task 0 Description"},
				new Task {Id = Guid.NewGuid(), Title = "Task 1 Title", Description = "Task 1 Description"},
				new Task {Id = Guid.NewGuid(), Title = "Task 2 Title", Description = "Task 2 Description"},
				new Task {Id = Guid.NewGuid(), Title = "Task 3 Title", Description = "Task 3 Description"},
				new Task {Id = Guid.NewGuid(), Title = "Task 4 Title", Description = "Task 4 Description"},
			};

			GetMockFor<ITaskRepository>()
				.Setup(r => r.Query())
				.Returns(Tasks);
		} 
	}
}