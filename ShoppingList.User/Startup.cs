using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShoppingList.User.Startup))]
namespace ShoppingList.User
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
