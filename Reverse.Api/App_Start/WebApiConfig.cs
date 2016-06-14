using Reverse.Api.StructureMap;
using StructureMap;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Dispatcher;

namespace Reverse.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var container = new Container();
            //container.Configure(c => c.For<ISearchResponseMapper>().Use<SearchResponseMapper

            config.Services.Replace(typeof(IHttpControllerActivator), new StructureMapControllerActivator(container));

            // enable cross site scripting for these domains.
            var cors = new EnableCorsAttribute("http://localhost:55820", "*", "*");
            config.EnableCors(cors);

            // Web API routes
            config.MapHttpAttributeRoutes();
            
            config.Routes.MapHttpRoute(
            name: "StatusAPI",
            routeTemplate: "status/{controller}/{id}",
            defaults: new { id = RouteParameter.Optional });

            config.Routes.MapHttpRoute(
            name: "ReverseAPI",
            routeTemplate: "reverse/{controller}/{id}",
            defaults: new { id = RouteParameter.Optional });
        }
    }
}
