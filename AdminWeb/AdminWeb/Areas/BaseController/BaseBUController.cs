using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.BaseController
{
    [Area(AreaName)]
    public class BaseBUController : Controller
    {
        public const string AreaName = "BUFeature";
    }
}
