using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab3_NgoHuuTai_2087700051.Startup))]
namespace Lab3_NgoHuuTai_2087700051
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
