using System.Web;
using System.Web.Mvc;

namespace u23614286_INF272_Prac08
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
