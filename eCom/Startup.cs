using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eCom.Startup))]
namespace eCom
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
