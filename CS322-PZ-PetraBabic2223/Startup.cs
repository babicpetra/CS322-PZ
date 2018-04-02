using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CS322_PZ_PetraBabic2223.Startup))]
namespace CS322_PZ_PetraBabic2223
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
