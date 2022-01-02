using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SkyionTechZone.Web.Startup))]
namespace SkyionTechZone.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
