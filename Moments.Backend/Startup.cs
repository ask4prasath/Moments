using Microsoft.Owin;
using Moments.Backend;
using Owin;

[assembly: OwinStartup(typeof(Startup))]

namespace Moments.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}