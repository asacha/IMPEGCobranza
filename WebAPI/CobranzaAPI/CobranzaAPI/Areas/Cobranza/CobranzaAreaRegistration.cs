using System.Web.Http;
using System.Web.Mvc;

namespace CobranzaAPI.Areas.Cobranza
{
    public class CobranzaAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Cobranza";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.Routes.MapHttpRoute(
                name: "CobranzaApi",
                routeTemplate: "Cobranza/api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            context.MapRoute(
                "Cobranza_default",
                "Cobranza/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}