using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_60322_Ivanov_Egor.Startup))]
namespace _60322_Ivanov_Egor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
