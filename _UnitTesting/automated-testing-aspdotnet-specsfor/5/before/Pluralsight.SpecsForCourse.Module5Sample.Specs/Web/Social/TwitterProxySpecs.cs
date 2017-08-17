using NUnit.Framework;
using Should;
using SpecsFor;
using Web.Social;

namespace Pluralsight.SpecsForCourse.Module5Sample.Specs.Web.Social
{
	public class TwitterProxySpecs
	{
		public class when_sharing_a_status : SpecsFor<TwitterProxy>
		{
			private SharingResult _result;

			protected override void InitializeClassUnderTest()
			{
				SUT = new TwitterProxy("http://some/test/url");
			}

			protected override void When()
			{
				_result = SUT.ShareStatus("Here's my status!");
			}

			[Test]
			public void then_it_succeeds()
			{
				_result.Succeeded.ShouldBeTrue();
			}

			[Test]
			public void then_it_posts_to_the_configured_url()
			{
				_result.SentTo.ShouldEqual("http://some/test/url");
			}
		}
	}
}