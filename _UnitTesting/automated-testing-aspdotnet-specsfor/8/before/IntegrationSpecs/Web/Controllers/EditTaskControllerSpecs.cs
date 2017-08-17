using System;
using System.Web.Mvc;
using IntegrationSpecs.TestHelpers;
using NUnit.Framework;
using SpecsFor;
using SpecsFor.Helpers.Web.Mvc;
using SpecsFor.ShouldExtensions;
using Web.Controllers;
using Web.Core;
using Web.Data;
using Web.Models;

namespace IntegrationSpecs.Web.Controllers
{
	public class EditTaskControllerSpecs
	{
		public class when_editing_an_existing_task 
			: SpecsFor<EditTaskController>, INeedDatabase, INeedMediator
		{
			public AppDbContext Database { get; set; }

			private Task _targetTask;

			protected override void Given()
			{
				_targetTask = new Task
				{
					Id = Guid.NewGuid(),
					Title = "Original title",
					Description = "Original description"
				};

				Database.Tasks.Add(_targetTask);

				Database.SaveChanges();
			}

			private ActionResult _result;
			protected override void When()
			{
				_result = SUT.Edit(new EditTaskForm
				{
					Id = _targetTask.Id,
					Title = "Updated title",
					Description = "Updated description"
				});
			}

			[Test]
			public void then_it_updates_the_target_task()
			{
				_targetTask.ShouldLookLike(new Task
				{
					Id = _targetTask.Id,
					Title = "Updated title",
					Description = "Updated description"
				});
			}

			[Test]
			public void then_it_redirects_to_the_view_page()
			{
				_result.ShouldRedirectTo<ViewTaskController>(
					c => c.ViewTask(_targetTask.Id));
			}
		}
	}
}