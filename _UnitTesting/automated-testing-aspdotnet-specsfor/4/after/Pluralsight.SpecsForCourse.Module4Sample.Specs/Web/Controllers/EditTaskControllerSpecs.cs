﻿using System;
using System.Web.Mvc;
using NUnit.Framework;
﻿using Pluralsight.SpecsForCourse.Module4Sample.Specs.TestHelpers;
﻿using Web.Controllers;
using Web.Core;
using Web.Data;
using Web.Infrastructure;
using Web.Models;
using SpecsFor;
using SpecsFor.Helpers.Web.Mvc;
using StructureMap;

namespace Pluralsight.SpecsForCourse.Module4Sample.Specs.Web.Controllers
{
	public class EditTaskControllerSpecs
	{
		public class when_editing_a_task : SpecsFor<EditTaskController>, INeedMediator
		{
			private Task _testTask;
			private ViewResult _result;

			protected override void Given()
			{
				_testTask = new Task
				{
					Id = Guid.NewGuid(),
					Title = "Test!",
					Description = "Test description!"
				};
				GetMockFor<ITaskRepository>()
					.Setup(r => r.FindById(_testTask.Id))
					.Returns(_testTask);
			}

			protected override void When()
			{
				_result = SUT.Edit(_testTask.Id);
			}

			[Test]
			public void then_it_renders_a_view_with_the_edit_task_form()
			{
				_result.ShouldRenderView()
					.WithModelLike(new EditTaskForm
					{
						Id = _testTask.Id,
						Title = "Test!",
						Description = "Test description!"
					});
			}
		}
	}
}