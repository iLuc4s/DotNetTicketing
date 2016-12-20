using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DotNetTicketing.Startup))]
namespace DotNetTicketing
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
