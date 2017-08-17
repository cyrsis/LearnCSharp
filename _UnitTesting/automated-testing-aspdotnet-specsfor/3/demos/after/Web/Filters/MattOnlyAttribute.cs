using System.Web.Mvc;
using Web.Domain;

namespace Web.Filters
{
	public class MattOnlyAttribute : ActionFilterAttribute
	{
		public ICurrentUser CurrentUser { get; set; }

		public override void OnActionExecuting(ActionExecutingContext filterContext)
		{
			if (CurrentUser.UserName != "Matt")
			{
				filterContext.Result =
					new ViewResult { ViewName = "YouAreNotMatt" };
			}
		}
	}
}