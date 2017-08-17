﻿using System;
using System.Linq;
using SpecsFor.Configuration;
using Web.Core;
using Web.Data;

namespace Pluralsight.SpecsForCourse.Module4Sample.Specs.TestHelpers
{
	public class LotsOfDummyDataProvider : Behavior<IHaveDummyData>
	{
		public override void Given(IHaveDummyData instance)
		{
			instance.DummyTasks = Enumerable.Range(0, 2500000)
				.Select(x => new Task
				{
					Id = Guid.NewGuid(),
					Title = "Task" + x + " Title",
					Description = "Task " + x + " Description"
				})
				.ToArray();

			instance.GetMockFor<ITaskRepository>()
				.Setup(r => r.Query())
				.Returns(() => instance.DummyTasks.AsQueryable());

		}
	}
}