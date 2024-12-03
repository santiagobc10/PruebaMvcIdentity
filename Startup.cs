using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PruebaMvcIdentity.Startup))]
namespace PruebaMvcIdentity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
