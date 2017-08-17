using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using IntegrationSpecs.TestHelpers;
using NUnit.Framework;
using Should;
using SpecsFor;
using SpecsFor.Mvc;
using SpecsFor.ShouldExtensions;
using Web.Core;
using Web.Data;

namespace EndToEndSpecs
{
	public class TasksApiSpecs
	{
		public class when_adding_a_new_task_through_the_api 
			: SpecsFor<MvcWebApp>, INeedDatabase
		{
			private HttpResponseMessage _result;

			public AppDbContext Database { get; set; }

			protected override void When()
			{
				using (var client = new HttpClient())
				{
					client.BaseAddress = new Uri(MvcWebApp.BaseUrl);
					client.DefaultRequestHeaders.Accept.Clear();
					client.DefaultRequestHeaders.Accept.Add(
						new MediaTypeWithQualityHeaderValue("application/json"));

					var task = new Task
					{
						Title = "Test from Web API!",
						Description = "My test task!"
					};

					_result = client.PostAsJsonAsync("api/tasks", task).Result;
				}
			}

			[Test]
			public void then_the_api_returns_success()
			{
				_result.IsSuccessStatusCode.ShouldBeTrue();
			}

			[Test]
			public void then_the_task_is_added_to_the_database()
			{
				Database.Tasks.Single()
					.ShouldLookLike(() => new Task
					{
						Title = "Test from Web API!",
						Description = "My test task!"
					});
			}

			[Test]
			public void then_the_api_returns_the_new_task()
			{
				var task = _result.Content.ReadAsAsync<Task>().Result;

				task.ShouldLookLike(() => new Task
				{
					Title = "Test from Web API!",
					Description = "My test task!"
				});

				task.Id.ShouldNotEqual(Guid.Empty);
			}
		}
	}
}