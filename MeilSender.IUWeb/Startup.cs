using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MeilSender.IUWeb.Startup))]
namespace MeilSender.IUWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
