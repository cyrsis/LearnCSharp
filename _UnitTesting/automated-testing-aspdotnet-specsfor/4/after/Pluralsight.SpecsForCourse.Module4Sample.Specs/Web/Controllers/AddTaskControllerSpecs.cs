using System;
using System.Web.Mvc;
using Moq;
using NUnit.Framework;
using SpecsFor;
using StructureMap;
using Web.Controllers;
using Web.Core;
using Web.Data;
using Web.Infrastructure;
using Web.Models;

namespace Pluralsight.SpecsForCourse.Module4Sample.Specs.Web.Controllers
{
	public class AddTaskControllerSpecs
	{
		public class when_adding_a_new_task : SpecsFor<AddTaskController>
		{
			private ActionResult _result;

			protected override void ConfigureContainer(IContainer container)
			{
				container.Configure(cfg => cfg.For<IIdGenerator>().Use<IdGenerator>());
			}

			protected override void When()
			{
				_result = SUT.Add(new AddTaskForm
				{
					Title = "Test task!",
					Description = "Some description!"
				});
			}

			[Test]
			public void then_it_adds_a_task_with_an_id()
			{
				GetMockFor<ITaskRepository>()
					.Verify(x => x.Add(It.Is<Task>(t => t.Id != Guid.Empty)));
			}
		}
	}
}