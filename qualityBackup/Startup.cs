using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(qualityBackup.Startup))]
namespace qualityBackup
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
