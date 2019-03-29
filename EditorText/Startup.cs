using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EditorText.Startup))]
namespace EditorText
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
