using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ColegioVRHT.WebClient.Startup))]
namespace ColegioVRHT.WebClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
