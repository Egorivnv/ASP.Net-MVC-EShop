using System.Web;
using System.Web.Mvc;

namespace _60322_Ivanov_Egor
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
