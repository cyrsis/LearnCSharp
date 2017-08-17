using OpenQA.Selenium.Chrome;
using SpecsFor;

namespace EndToEndSpecs.Helpers
{
	public abstract class BaseEndToEndSpecs : SpecsFor<ChromeDriver>
	{
		protected const string BaseUrl = "http://localhost:50001/";

		protected override void InitializeClassUnderTest()
		{
			SUT = new ChromeDriver();
		}
	}
}