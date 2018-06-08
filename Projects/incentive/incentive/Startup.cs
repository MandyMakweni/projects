using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(incentive.Startup))]
namespace incentive
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
