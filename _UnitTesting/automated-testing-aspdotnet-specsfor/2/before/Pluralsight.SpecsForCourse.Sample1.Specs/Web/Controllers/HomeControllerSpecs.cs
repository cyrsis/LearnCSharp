using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using NUnit.Framework;
using Web.Controllers;
using Web.Models;

namespace Pluralsight.SpecsForCourse.Sample1.Specs.Web.Controllers
{
	[TestFixture]
	public class HomeControllerSpecs
	{
		[Test]
		public void index_action_returns_a_view_result()
		{
			var sut = new HomeController();

			var result = sut.Index();

			Assert.That(result, Is.TypeOf<ViewResult>());
		}
	
		[Test]
		public void index_action_says_hello_world()
		{
			var sut = new HomeController();

			sut.Index();

			Assert.That(sut.ViewBag.Message, Is.EqualTo("Hello, world!"));
		}

		[Test]
		public void say_hello_action_says_hello_to_the_specified_user()
		{
			var sut = new HomeController();

			var result = sut.SayHello("John Doe");

			Assert.That(result, Is.TypeOf<ViewResult>());
			Assert.That(((ViewResult)result).Model, Is.TypeOf<SayHelloViewModel>());
			Assert.That(((SayHelloViewModel)((ViewResult)result).Model).Name, Is.EqualTo("John Doe"));
		}

		[Test]
		public void say_hello_post_action_redirects_for_the_specified_user()
		{
			var sut = new HomeController();

			var result = sut.SayHello(new SayHelloForm{Name = "Jane Doe"});

			Assert.That(result, Is.TypeOf<RedirectToRouteResult>());
			
			var routeResult = (RedirectToRouteResult) result;
			Assert.That(routeResult.RouteValues["action"], Is.EqualTo("SayHello"));
			Assert.That(routeResult.RouteValues["name"], Is.EqualTo("Jane Doe"));
		}
	}
}
