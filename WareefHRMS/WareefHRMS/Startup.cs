using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WareefHRMS.Startup))]
namespace WareefHRMS
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
