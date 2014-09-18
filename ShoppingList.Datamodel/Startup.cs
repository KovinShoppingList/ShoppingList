using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShoppingList.Datamodel.Startup))]
namespace ShoppingList.Datamodel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
