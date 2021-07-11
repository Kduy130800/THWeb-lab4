using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(THWeb_lab4.Startup))]
namespace THWeb_lab4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
