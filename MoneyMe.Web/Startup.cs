using Microsoft.Owin;
using MoneyMe.Web.Models.Scaffolding;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoneyMe.Web.Startup))]
namespace MoneyMe.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var db = new ScaffoldDbContext();
            ConfigureAuth(app);
        }
    }
}
