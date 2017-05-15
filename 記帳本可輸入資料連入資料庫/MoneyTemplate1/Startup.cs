using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoneyTemplate1.Startup))]
namespace MoneyTemplate1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
