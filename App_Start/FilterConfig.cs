using System.Web;
using System.Web.Mvc;

namespace NEW_E_COMMERCE_WEB_APPLICATION
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
