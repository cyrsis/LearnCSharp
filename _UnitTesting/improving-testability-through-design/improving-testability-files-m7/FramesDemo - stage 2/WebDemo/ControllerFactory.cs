using System;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;
using WebDemo.Controllers;
using WebDemo.DataAccessLayer;
using WebDemo.Gateway;

namespace WebDemo
{
    public class ControllerFactory: IControllerFactory
    {
        public IController CreateController(RequestContext requestContext, string controllerName)
        {

            if (controllerName == "Home")
            {
                return new HomeController(
                    new DataGateway(
                        new DataAccess()));
            }

            return null;
        
        }

        public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
        {
            return SessionStateBehavior.Default;
        }

        public void ReleaseController(IController controller)
        {
            IDisposable disposable = controller as IDisposable;
            if (disposable != null)
                disposable.Dispose();
        }
    }
}