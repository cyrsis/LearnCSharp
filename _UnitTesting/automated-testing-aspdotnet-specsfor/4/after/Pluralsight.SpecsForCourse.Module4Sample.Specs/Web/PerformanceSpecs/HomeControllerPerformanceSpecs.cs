﻿using System.Web.Mvc;
using NUnit.Framework;
using Pluralsight.SpecsForCourse.Module4Sample.Specs.TestHelpers;
using Should;
using SpecsFor;
using SpecsFor.Helpers.Web.Mvc;
using Web.Controllers;
using Web.Core;
using Web.Models;

namespace Pluralsight.SpecsForCourse.Module4Sample.Specs.Web.PerformanceSpecs
{
	public class HomeControllerPerformanceSpecs
	{
		public class when_getting_a_list_of_issues : SpecsFor<HomeController>,
			IHaveDummyData
		{
			private ActionResult _result;

			public Task[] DummyTasks { get; set; }

			protected override void When()
			{
				_result = SUT.Index();
			}

			[Test]
			public void then_it_returns_a_bunch_of_data()
			{
				_result.ShouldRenderDefaultView()
					.WithModelType<TaskSummaryViewModel[]>()
					.Length.ShouldBeGreaterThan(100);
			}
		}
	}
}