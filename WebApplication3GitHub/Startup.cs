using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication3GitHub.Startup))]
namespace WebApplication3GitHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
