using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Action.API.Startup))]

namespace Action.API
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
