using Plataforma.Controllers;
using System.Web;
using System.Web.Mvc;

namespace proyecto.Filters
{
    public class VerifySession:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var usuario = HttpContext.Current.Session["User"];
            if(usuario == null)
            {
                if (filterContext.Controller is AdminController == false)
                {
                    filterContext.HttpContext.Response.Redirect("~/Inicio/Index");
                }
            }
            base.OnActionExecuting(filterContext);
        }
    }
}