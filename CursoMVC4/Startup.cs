using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CursoMVC4.Startup))]
namespace CursoMVC4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
