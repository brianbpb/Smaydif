using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Smaydif.Startup))]
namespace Smaydif
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
