using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Samydif.Startup))]
namespace Samydif
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
