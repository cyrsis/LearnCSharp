using System;
using System.Linq;
using IntegrationSpecs.TestHelpers;
using NUnit.Framework;
using Should;
using SpecsFor;
using SpecsFor.Mvc;
using SpecsFor.Mvc.Helpers;
using SpecsFor.ShouldExtensions;
using Web.Controllers;
using Web.Core;
using Web.Data;
using Web.Models;

namespace EndToEndSpecs
{
	public class TaskSpecs
	{
		public class when_adding_a_task : SpecsFor<MvcWebApp>, INeedDatabase
		{
			private Task _task;

			public AppDbContext Database { get; set; }

			protected override void When()
			{
				SUT.NavigateTo<HomeController>(c => c.Index());
				SUT.FindLinkTo<AddTaskController>(c => c.Add())
					.Click();

				SUT.FindFormFor<AddTaskForm>()
					.Field(x => x.Title).SetValueTo("Task from specs!")
					.Field(x => x.Description).SetValueTo("Test description!")
					.Submit();

				_task = Database.Tasks.SingleOrDefault();
			}

			[Test]
			public void then_it_adds_a_task_with_the_expected_data()
			{
				_task.ShouldLookLike(()=> new Task
				{
					Title = "Task from specs!",
					Description = "Test description!"
				});
			}

			[Test]
			public void then_it_navigates_to_the_view_page_for_the_task()
			{
				SUT.Route.ShouldMapTo<ViewTaskController>(c => c.ViewTask(_task.Id));
			}
		}

		public class when_trying_to_submit_an_invalid_task : SpecsFor<MvcWebApp>
		{
			protected override void When()
			{
				SUT.NavigateTo<AddTaskController>(c => c.Add());

				SUT.FindFormFor<AddTaskForm>()
					.Field(x => x.Title).SetValueTo("")
					.Submit();
			}

			[Test]
			public void then_it_flags_the_title_as_invalid()
			{
				SUT.FindFormFor<AddTaskForm>()
					.Field(x => x.Title).ShouldBeInvalid();
			}
		}

		public class when_viewing_an_existing_task : SpecsFor<MvcWebApp>, INeedDatabase
		{
			private Task _task;
			public AppDbContext Database { get; set; }

			protected override void Given()
			{
				_task = new Task
				{
					Id = Guid.NewGuid(),
					Title = "Test Task!",
					Description = "Test description!"
				};

				Database.Tasks.Add(_task);
				Database.SaveChanges();
			}

			protected override void When()
			{
				SUT.NavigateTo<ViewTaskController>(c => c.ViewTask(_task.Id));
			}

			[Test]
			public void then_it_displays_the_title_for_the_task()
			{
				SUT.FindDisplayFor<TaskDetailsViewModel>()
					.DisplayFor(x => x.Title)
					.Text.ShouldEqual("Test Task!");
			}

			[Test]
			public void then_it_displays_the_description_of_the_task()
			{
				SUT.FindDisplayFor<TaskDetailsViewModel>()
					.DisplayFor(x => x.Description)
					.Text.ShouldEqual("Test description!");
			}
		}
	}
}