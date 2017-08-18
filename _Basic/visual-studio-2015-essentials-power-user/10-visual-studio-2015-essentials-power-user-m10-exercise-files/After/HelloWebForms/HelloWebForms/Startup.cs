using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloWebForms.Startup))]
namespace HelloWebForms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
