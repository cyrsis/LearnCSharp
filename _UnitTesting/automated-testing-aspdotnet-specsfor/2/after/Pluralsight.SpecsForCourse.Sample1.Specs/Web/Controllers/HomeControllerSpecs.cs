using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Moq;
using NUnit.Framework;
using Web.Controllers;
using Web.Domain;
using Web.Models;

namespace Pluralsight.SpecsForCourse.Sample1.Specs.Web.Controllers
{
	[TestFixture]
	public class HomeControllerSpecs
	{
		[Test]
		public void index_action_returns_a_view_result()
		{
			var mock = new Mock<ICurrentUser>();
			var sut = new HomeController(mock.Object);

			var result = sut.Index();

			Assert.That(result, Is.TypeOf<ViewResult>());
		}
	
		[Test]
		public void index_action_says_hello_world()
		{
			var mock = new Mock<ICurrentUser>();
			mock.Setup(x => x.UserName).Returns("John Smith");
			var sut = new HomeController(mock.Object);

			sut.Index();

			Assert.That(sut.ViewBag.Message, Is.EqualTo("Hello, John Smith!"));
		}

		[Test]
		public void say_hello_action_says_hello_to_the_specified_user()
		{
			var mock = new Mock<ICurrentUser>();
			var sut = new HomeController(mock.Object);

			var result = sut.SayHello("John Doe");

			Assert.That(result, Is.TypeOf<ViewResult>());
			Assert.That(((ViewResult)result).Model, Is.TypeOf<SayHelloViewModel>());
			Assert.That(((SayHelloViewModel)((ViewResult)result).Model).Name, Is.EqualTo("John Doe"));
		}

		[Test]
		public void say_hello_post_action_redirects_for_the_specified_user()
		{
			var mock = new Mock<ICurrentUser>();
			var sut = new HomeController(mock.Object);

			var result = sut.SayHello(new SayHelloForm{Name = "Jane Doe"});

			Assert.That(result, Is.TypeOf<RedirectToRouteResult>());
			
			var routeResult = (RedirectToRouteResult) result;
			Assert.That(routeResult.RouteValues["action"], Is.EqualTo("SayHello"));
			Assert.That(routeResult.RouteValues["name"], Is.EqualTo("Jane Doe"));
		}

		[Test]
		public void setting_name_changes_the_name_of_the_current_user()
		{
			var mock = new Mock<ICurrentUser>();

			var sut = new HomeController(mock.Object);

			var result = sut.SetName("Jane Doe");

			mock.Verify(x => x.SetName("Jane Doe"));

			Assert.That(result, Is.TypeOf<RedirectToRouteResult>());

			var routeResult = (RedirectToRouteResult)result;
			Assert.That(routeResult.RouteValues["action"], Is.EqualTo("Index"));
		}

		[Test]
		public void trying_to_set_an_empty_name_fails()
		{
			var mock = new Mock<ICurrentUser>();

			var sut = new HomeController(mock.Object);

			var result = sut.SetName(null);

			mock.Verify(x => x.SetName(It.IsAny<string>()), Times.Never);

			Assert.That(result, Is.TypeOf<ViewResult>());
		}
	}
}
