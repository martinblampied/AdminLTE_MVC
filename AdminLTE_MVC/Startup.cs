using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdminLTE_MVC.Startup))]
namespace AdminLTE_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
