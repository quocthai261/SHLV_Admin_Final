using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.BaseController
{
    [Area(AreaName)]
    public class BaseAdminController : Controller
    {
        public const string AreaName = "Admin";
    }
}
