using System;
using System.Linq;
using System.Web.Mvc;
using NUnit.Framework;
using Pluralsight.SpecsForCourse.Module4Sample.Specs.TestHelpers;
using Should;
using SpecsFor;
using SpecsFor.Helpers.Web.Mvc;
using SpecsFor.ShouldExtensions;
using Web.Controllers;
using Web.Core;
using Web.Data;
using Web.Models;

namespace Pluralsight.SpecsForCourse.Module4Sample.Specs.Web.Controllers
{
	public class HomeControllerSpecs
	{
		public class when_listing_tasks : SpecsFor<HomeController>, IHaveDummyData
		{
			private ActionResult _result;

			public Task[] DummyTasks { get; set; }

			protected override void When()
			{
				_result = SUT.Index();
			}

			[Test]
			public void then_it_returns_a_view_with_task_summaries()
			{
				_result.ShouldRenderView()
					.WithModelType<TaskSummaryViewModel[]>();
			}

			[Test]
			public void then_it_should_return_the_expected_number_of_tasks()
			{
				_result.ShouldRenderView()
					.WithModelType<TaskSummaryViewModel[]>()
					.Length.ShouldEqual(5);
			}

			[Test]
			public void then_it_populates_the_summaries_correctly()
			{
				_result.ShouldRenderView()
					.WithModelType<TaskSummaryViewModel[]>()
					.First().ShouldLookLike(new TaskSummaryViewModel
					{
						Id = DummyTasks[0].Id,
						Title = "Task 0 Title"
					});
			}
		}
	}
}