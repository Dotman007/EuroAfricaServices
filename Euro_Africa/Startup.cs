using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Euro_Africa.Startup))]
namespace Euro_Africa
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
