using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pojeto_Final.Startup))]
namespace Pojeto_Final
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
