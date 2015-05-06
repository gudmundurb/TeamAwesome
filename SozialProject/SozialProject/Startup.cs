using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SozialProject.Startup))]
namespace SozialProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
