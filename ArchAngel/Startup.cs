using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ArchAngel.Startup))]
namespace ArchAngel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
