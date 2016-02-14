using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleApps.Startup))]
namespace SampleApps
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
