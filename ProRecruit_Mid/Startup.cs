using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProRecruit_Mid.Startup))]
namespace ProRecruit_Mid
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
