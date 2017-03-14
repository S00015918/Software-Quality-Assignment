using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CaculatePremium.Startup))]
namespace CaculatePremium
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
