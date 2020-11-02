using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GigerSport.Startup))]
namespace GigerSport
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
