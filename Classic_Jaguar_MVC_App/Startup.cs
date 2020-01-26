using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Classic_Jaguar_MVC_App.Startup))]
namespace Classic_Jaguar_MVC_App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
