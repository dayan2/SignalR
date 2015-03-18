using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Part1_FirstHub.Startup))]
namespace Part1_FirstHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
