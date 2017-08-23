using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPIdentiy.Startup))]
namespace ASPIdentiy
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
