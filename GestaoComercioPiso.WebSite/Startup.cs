using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GestaoComercioPiso.WebSite.Startup))]
namespace GestaoComercioPiso.WebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
