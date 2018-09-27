using System.Web.Http;
using System.Web.Mvc;

namespace CobranzaAPI.Areas.Catalogo
{
    public class CatalogoAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Catalogo";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.Routes.MapHttpRoute(
                name: "CatalogoApi",
                routeTemplate: "Catalogo/api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            context.MapRoute(
                "Catalogo_default",
                "Catalogo/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}