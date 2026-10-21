using System.Web;
using System.Web.Mvc;

namespace FE1_TranTheHien
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
