using System.Web.Http;
using System.Web.Routing;

namespace FieldEngineer_super_lite_server
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            WebApiConfig.Register();
        }
    }
}