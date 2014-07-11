using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RequestManagement.Startup))]
namespace RequestManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
