using System.Web;
using System.Web.Mvc;

namespace Ulatina.Topicos.Calentamiento
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
