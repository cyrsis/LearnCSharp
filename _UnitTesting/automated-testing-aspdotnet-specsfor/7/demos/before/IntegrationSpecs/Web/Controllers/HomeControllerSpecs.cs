using System;
using System.Web.Mvc;
using IntegrationSpecs.TestHelpers;
using NUnit.Framework;
using Should;
using SpecsFor;
using SpecsFor.Helpers.Web.Mvc;
using Web.Controllers;
using Web.Core;
using Web.Data;
using Web.Models;

namespace IntegrationSpecs.Web.Controllers
{
	public class HomeControllerSpecs
	{
		public class when_getting_a_list_of_tasks 
			: SpecsFor<HomeController>, INeedDatabase
		{
			public AppDbContext Database { get; set; }

			protected override void Given()
			{
				for (var i = 0; i < 5; i++)
				{
					Database.Tasks.Add(new Task
					{
						Id = Guid.NewGuid(),
						Title = "Task " + i,
						Description = "Dummy task " + i
					});
				}

				Database.SaveChanges();
			}

			private ActionResult _result;
			protected override void When()
			{
				_result = SUT.Index();
			}

			[Test]
			public void then_it_returns_tasks()
			{
				_result.ShouldRenderDefaultView()
					.WithModelType<TaskSummaryViewModel[]>()
					.Length.ShouldEqual(5);
			}
		}
	}
}