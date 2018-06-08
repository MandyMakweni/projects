using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OM.Startup))]
namespace OM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
