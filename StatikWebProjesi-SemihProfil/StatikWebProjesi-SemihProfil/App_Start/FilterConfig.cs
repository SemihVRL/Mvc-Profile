using System.Web;
using System.Web.Mvc;

namespace StatikWebProjesi_SemihProfil
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
