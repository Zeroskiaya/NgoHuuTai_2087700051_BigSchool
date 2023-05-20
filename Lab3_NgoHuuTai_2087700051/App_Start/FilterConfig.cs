using System.Web;
using System.Web.Mvc;

namespace Lab3_NgoHuuTai_2087700051
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
