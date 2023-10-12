using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Controllers
{
    public class CultureController : Controller
    {
        [HttpPost]
        [Route("Culture/SetCulture",Name = "SetCulture")]
        public IActionResult SetCulture(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );
            return LocalRedirect(returnUrl);
        }
    }
}

