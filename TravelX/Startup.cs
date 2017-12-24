using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TravelX.Startup))]
namespace TravelX
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
