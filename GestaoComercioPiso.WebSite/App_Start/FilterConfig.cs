using System.Web;
using System.Web.Mvc;

namespace GestaoComercioPiso.WebSite
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
