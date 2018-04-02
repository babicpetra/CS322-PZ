using System.Web;
using System.Web.Mvc;

namespace CS322_PZ_PetraBabic2223
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
