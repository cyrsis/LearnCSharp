using NUnit.Framework;
using Pluralsight.SpecsForCourse.Module4Sample.Specs.TestHelpers;
using SpecsFor.Configuration;

namespace Pluralsight.SpecsForCourse.Module4Sample.Specs.Web
{
	[SetUpFixture]
	public class SpecsForConfig : SpecsForConfiguration
	{
		public SpecsForConfig()
		{
			WhenTesting<IHaveDummyData>().EnrichWith<DummyDataProvider>();
			WhenTesting<INeedMediator>().EnrichWith<MediatorProvider>();
		}
	}
}