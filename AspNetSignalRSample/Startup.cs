using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(AspNetSignalRSample.Startup))]
namespace AspNetSignalRSample
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
