using Microsoft.Owin;
using Owin;

[assembly: OwinStartup("StartupDev",typeof(AuthorisationServer.OwinStartup))]

namespace AuthorisationServer
{
    public class OwinStartup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}
