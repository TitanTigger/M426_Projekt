using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(M426_Projekt_NET.Startup))]
namespace M426_Projekt_NET
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
