using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Smartkey_Calculator.Startup))]
namespace Smartkey_Calculator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
