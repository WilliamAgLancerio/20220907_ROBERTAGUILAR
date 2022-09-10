using System.Web;
using System.Web.Mvc;

namespace _20220907_ROBERT_AGUILAR
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
