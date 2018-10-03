using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(juefi2.Startup))]
namespace juefi2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
