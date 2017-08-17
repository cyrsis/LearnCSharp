using EndToEndSpecs.Helpers;
using IntegrationSpecs.TestHelpers;
using NUnit.Framework;
using SpecsFor.Configuration;

namespace EndToEndSpecs
{
	[SetUpFixture]
	public class EndToEndSpecsConfig : SpecsForConfiguration
	{
		private IISExpressRunner _runner;

		public EndToEndSpecsConfig()
		{
			WhenTesting<INeedDatabase>().EnrichWith<EFContextFactory>();
		}

		protected override void AfterConfigurationApplied()
		{
			_runner = new IISExpressRunner();
			_runner.StartProcess();
		}

		protected override void AfterConfigurationRemoved()
		{
			_runner.StopProcess();
		}
	}
}