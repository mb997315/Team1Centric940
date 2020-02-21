using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Team1Centric940.Startup))]
namespace Team1Centric940
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
