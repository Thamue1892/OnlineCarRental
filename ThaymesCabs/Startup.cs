using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThaymesCabs.Startup))]
namespace ThaymesCabs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
