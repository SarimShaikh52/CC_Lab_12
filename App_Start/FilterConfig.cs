using System.Web;
using System.Web.Mvc;

namespace Sarim_CC_Lab12
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
