using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TatApp.Backend.Startup))]
namespace TatApp.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
