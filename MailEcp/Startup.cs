using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MailEcp.Startup))]
namespace MailEcp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
