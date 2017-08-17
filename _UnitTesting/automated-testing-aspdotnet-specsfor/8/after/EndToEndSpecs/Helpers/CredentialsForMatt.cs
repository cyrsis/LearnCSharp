using SpecsFor.Mvc;
using SpecsFor.Mvc.Authentication;
using Web.Controllers;
using Web.Models;

namespace EndToEndSpecs.Helpers
{
	public class CredentialsForMatt : IHandleAuthentication
	{
		public void Authenticate(MvcWebApp mvcWebApp)
		{
			mvcWebApp.NavigateTo<HomeController>(c => c.Index());

			if (mvcWebApp.UrlMapsTo<HomeController>(c => c.Index())) return;

			mvcWebApp.FindFormFor<LogOnForm>()
				.Field(x => x.Username).SetValueTo("Matt")
				.Field(x => x.Password).SetValueTo("Password1")
				.Submit();
		}
	}
}