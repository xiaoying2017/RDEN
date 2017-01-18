using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mzxxzy.Startup))]
namespace mzxxzy
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
