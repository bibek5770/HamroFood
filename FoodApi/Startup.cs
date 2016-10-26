using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(FoodApi.Startup))]

namespace FoodApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
