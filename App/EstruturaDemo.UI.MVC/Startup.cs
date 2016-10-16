using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EstruturaDemo.UI.MVC.Startup))]
namespace EstruturaDemo.UI.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
