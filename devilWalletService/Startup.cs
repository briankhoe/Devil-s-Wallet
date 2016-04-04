using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(devilWalletService.Startup))]

namespace devilWalletService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}