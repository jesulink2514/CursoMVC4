using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RoutingSample.Startup))]
namespace RoutingSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
