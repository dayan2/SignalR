using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SignalR_New.Startup))]
namespace SignalR_New
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);

            // Register the default hubs route: ~/signalr/hubs
            app.MapSignalR();
        }
    }
}
