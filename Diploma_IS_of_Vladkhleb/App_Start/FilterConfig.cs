using System.Web;
using System.Web.Mvc;

namespace Diploma_IS_of_Vladkhleb
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
