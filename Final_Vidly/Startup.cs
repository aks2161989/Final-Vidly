using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Final_Vidly.Startup))]
namespace Final_Vidly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
