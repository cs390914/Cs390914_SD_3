using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cs390914_SD_3.Startup))]
namespace Cs390914_SD_3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
