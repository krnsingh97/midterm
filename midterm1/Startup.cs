using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(midterm1.Startup))]
namespace midterm1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
