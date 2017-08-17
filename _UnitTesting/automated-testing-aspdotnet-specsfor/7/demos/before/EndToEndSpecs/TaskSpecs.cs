using System;
using System.Linq;
using EndToEndSpecs.Helpers;
using IntegrationSpecs.TestHelpers;
using NUnit.Framework;
using OpenQA.Selenium;
using Should;
using SpecsFor;
using Web.Core;
using Web.Data;

namespace EndToEndSpecs
{
	public class TaskSpecs
	{
		public class when_creating_a_new_task : BaseEndToEndSpecs
		{
			private string _id;

			protected override void When()
			{
				SUT.Navigate().GoToUrl(BaseUrl);
				SUT.FindElementByLinkText("Add Task").Click();

				_id = Guid.NewGuid().ToString();
				SUT.FindElementById("Title").SendKeys("Test Task " + _id);
				SUT.FindElementById("Description").SendKeys("Test description!");

				SUT.FindElementByCssSelector("button[type='submit']").Click();
			}

			[Test]
			public void then_it_takes_you_to_the_view_page_for_that_task()
			{
				SUT.FindElementByTagName("h2").Text
					.ShouldEqual("Test Task " + _id);
			}

			[Test]
			public void then_it_sets_the_description()
			{
				SUT.FindElementByCssSelector("div.well").Text
					.ShouldEqual("Test description!");
			}
		}

		public class when_viewing_an_existing_task 
			: BaseEndToEndSpecs, INeedDatabase
		{
			private Task _task;
			public AppDbContext Database { get; set; }

			protected override void Given()
			{
				_task = new Task
				{
					Id = Guid.NewGuid(),
					Title = "My End-To-End Task Title!",
					Description = "My Test Description"
				};

				Database.Tasks.Add(_task);

				Database.SaveChanges();
			}

			protected override void When()
			{
				SUT.Navigate().GoToUrl(BaseUrl);
				//Click on our task
				SUT.FindElements(By.TagName("a"))
					.Single(x => x.GetAttribute("href")
						.EndsWith(_task.Id.ToString()))
					.Click();
			}

			[Test]
			public void then_it_displays_the_title_for_the_task()
			{
				SUT.FindElementByTagName("h2").Text
					.ShouldEqual("My End-To-End Task Title!");
			}

			[Test]
			public void then_it_displays_the_description_of_the_task()
			{
				SUT.FindElementByCssSelector("div.well").Text
					.ShouldEqual("My Test Description");
			}

		}
	}
}