using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConexionCodeFirst.Startup))]
namespace ConexionCodeFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
