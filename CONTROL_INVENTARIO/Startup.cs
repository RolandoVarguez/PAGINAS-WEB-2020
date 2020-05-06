using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CONTROL_INVENTARIO.Startup))]
namespace CONTROL_INVENTARIO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
