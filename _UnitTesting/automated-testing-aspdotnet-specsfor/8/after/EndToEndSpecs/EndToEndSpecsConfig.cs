using EndToEndSpecs.Helpers;
using IntegrationSpecs.TestHelpers;
using NUnit.Framework;
using SpecsFor;
using SpecsFor.Configuration;
using SpecsFor.Mvc;
using Web;

namespace EndToEndSpecs
{
	[SetUpFixture]
	public class EndToEndSpecsConfig : SpecsForConfiguration
	{
		private SpecsForIntegrationHost _host;

		public EndToEndSpecsConfig()
		{
			WhenTesting<INeedDatabase>().EnrichWith<EFContextFactory>();
			WhenTesting<SpecsFor<MvcWebApp>>().EnrichWith<EndToEndDatabaseCreator>();
			WhenTesting<SpecsFor<MvcWebApp>>().EnrichWith<DataPurger>();
		}

		protected override void AfterConfigurationApplied()
		{
			var config = new SpecsForMvcConfig();
			config.UseIISExpress()
				.With(Project.Named("Web"))
				.ApplyWebConfigTransformForConfig("EndToEndSpecs");

			config.BuildRoutesUsing(x => RouteConfig.RegisterRoutes(x));

			config.UseBrowser(BrowserDriver.Chrome);

			config.AuthenticateBeforeEachTestUsing<CredentialsForMatt>();

			config.InterceptEmailMessagesOnPort(59025);

			_host = new SpecsForIntegrationHost(config);
			_host.Start();
		}

		protected override void AfterConfigurationRemoved()
		{
			_host.Shutdown();
		}
	}
}