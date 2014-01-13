using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AJaxSample.Startup))]
namespace AJaxSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
