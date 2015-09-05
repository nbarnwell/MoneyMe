using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoneyMe.Web.Startup))]
namespace MoneyMe.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
