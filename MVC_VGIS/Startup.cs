using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_VGIS.Startup))]
namespace MVC_VGIS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
