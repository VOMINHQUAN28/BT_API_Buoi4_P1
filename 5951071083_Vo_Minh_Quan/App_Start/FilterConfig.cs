using System.Web;
using System.Web.Mvc;

namespace _5951071083_Vo_Minh_Quan
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
