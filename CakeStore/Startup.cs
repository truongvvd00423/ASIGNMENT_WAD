using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CakeStore.Startup))]
namespace CakeStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
