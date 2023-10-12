using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Admin.Controllers
{
    public class SmtpConfigController : BaseAdminController
    {
        private readonly IApiService _apiService;

        public SmtpConfigController(IApiService apiService)
        {
            _apiService = apiService;
        }

        public IActionResult Index()
        {
            return RedirectToAction("List");
        }

        public IActionResult List()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpGet]
        public object GetSmtpConfigList(DataSourceLoadOptions loadOptions)
        {
            var _response = smtpConfigList;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<SmtpConfigResponseModel> smtpConfigList = new List<SmtpConfigResponseModel>()
        {
            new SmtpConfigResponseModel()
            {
                SmtpConfigId = 2,
                NetworkCredentialUsername = "sdms@shinhanlife.com.vn",
                NetworkCredentialPassword = "LIME@2021!",
                FromAddress = "sdms@shinhanlife.com.vn",
                FromDisplayName = "SDMS Admin",
                EnableSSL = true,
                SmtpClientPort = "25",
                SmtpClientHost = "mail.shinhanlife.com.vn",
                Active = true,
                GroupCode = "SLVN_SDMS",
                ListMailCC = "agency.admin@shinhanlife.com",
                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
        };
    }
}
