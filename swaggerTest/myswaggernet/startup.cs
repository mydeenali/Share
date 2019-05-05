using Owin;
using System.Web.Http;

namespace OwinSelfhostSample
{
    public class Startup
    {
        // This code configures Web API. The Startup class is specified as a type
        // parameter in the WebApp.Start method.
        public void Configuration(IAppBuilder appBuilder)
        {
            // Configure Web API for self-host. 
           // myswaggernet.testSwaggerConfig.Register();
            HttpConfiguration config = new HttpConfiguration();





            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.Routes.MapHttpRoute("Images", "api/{namespace}/{controller}/Images/{id}",
             new { id = RouteParameter.Optional }, null);
            
            Swagger.Net.Dummy.SwaggerConfig.Register(config);
            //SwaggerConfig.Register(config);
            //Swagger.N.et.Application.HttpConfigurationExtensions.EnableSwagger(config, c => c.SingleApiVersion("v1", "A title for your API"));
            //Swagger.Net.Application.SwaggerEnabledConfiguration.
            //            Swagger.Net.Application.HttpConfigurationExtensions.EnableSwagger(config, c => c.SingleApiVersion("v1", "A title for your API"));

            //config.EnableSwagger(c => c.SingleApiVersion("v1", "A title for your API"));
            //config.EnableSwaggerUi();

            appBuilder.UseWebApi(config);
        }
    }
}