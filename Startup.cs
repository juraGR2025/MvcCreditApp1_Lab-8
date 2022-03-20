using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcCreditApp1_Lab_8.Startup))]
namespace MvcCreditApp1_Lab_8
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
