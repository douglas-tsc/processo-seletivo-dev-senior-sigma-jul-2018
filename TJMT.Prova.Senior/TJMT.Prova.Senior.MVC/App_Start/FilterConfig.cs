using System.Web;
using System.Web.Mvc;

namespace TJMT.Prova.Senior.MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
