using AdminWeb.Areas.BaseController;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Admin.Controllers
{
	public class HomeController : BaseAdminController
    {
		public IActionResult Index()
		{
			return View();
		}
	}
}
