using System.Web;
using System.Web.Mvc;

namespace Netflix_Dashboard_mk1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
