using OpenQA.Selenium;
using SpecsFor.Mvc;

namespace EndToEndSpecs.Helpers
{
	public static class ModalHelperExtension
	{
		public static ModalHelper<TForm> FindModalFor<TForm>(this MvcWebApp app)
			where TForm : class
		{
			return new ModalHelper<TForm>(app);
		}
	}

	public class ModalHelper<TForm> where TForm : class 
	{
		private readonly MvcWebApp _app;

		public ModalHelper(MvcWebApp app)
		{
			_app = app;
		}

		public ModalHelper<TForm> Activate()
		{
			var selector = string.Format("a[href='#{0}'", typeof(TForm).Name);

			_app.Browser.FindElementByCssSelector(selector)
				.Click();

			_app.WaitForElementToBeVisible(By.Id(typeof(TForm).Name),
				throwOnTimeout: true);

			return this;
		}

		public FluentForm<TForm> GetForm()
		{
			return _app.FindFormFor<TForm>();
		}
	}
}