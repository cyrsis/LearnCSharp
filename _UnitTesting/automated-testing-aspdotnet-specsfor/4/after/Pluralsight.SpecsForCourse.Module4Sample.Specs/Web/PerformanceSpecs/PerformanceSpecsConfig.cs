using NUnit.Framework;
using Pluralsight.SpecsForCourse.Module4Sample.Specs.TestHelpers;
using SpecsFor.Configuration;

namespace Pluralsight.SpecsForCourse.Module4Sample.Specs.Web.PerformanceSpecs
{
	[SetUpFixture]
	public class PerformanceSpecsConfig : SpecsForConfiguration
	{
		public PerformanceSpecsConfig()
		{
			WhenTestingAnything().EnrichWith<TestTimingProvider>();
			WhenTesting<IHaveDummyData>().EnrichWith<LotsOfDummyDataProvider>();
		}
	}
}