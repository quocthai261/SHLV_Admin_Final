using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{
    public class EmailTemplateController : BaseCategoryController
    {
        private readonly IApiService _apiService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public EmailTemplateController(IApiService apiService, IHttpContextAccessor httpContextAccessor)
        {
            _apiService = apiService;
            _httpContextAccessor = httpContextAccessor;
        }
        public IActionResult Index()
        {
            return RedirectToAction("List");
        }

        public IActionResult List()
        {
            try
            {
                //_httpContextAccessor.HttpContext.Session.SetString("ActiveMenuItemSystemName", "EmailTemplate");
                //_httpContextAccessor.HttpContext.Session.SetString("ActiveParentMenuSystemName", "Category");

                return View();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        [HttpGet]
        public object GetDataTableList(DataSourceLoadOptions loadOptions)
        {
            var _response = model;

            return DataSourceLoader.Load(_response, loadOptions);
        }


        public static List<EmailTemplateResponseModel> model = new List<EmailTemplateResponseModel>()
        {
            new EmailTemplateResponseModel {
                        EmailTemplateId = 1,
                        Creator = "admin",
                        EffectDate = DateTime.Now,
                        Subject = "Xóa tài khoản",
                        Name = "Xóa tài khoản",
                        Content = "<p>Dear Admin,</p>",

                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new EmailTemplateResponseModel {
                        EmailTemplateId = 2,
                        Creator = "admin",
                        EffectDate = DateTime.Now,
                        Subject = "Chuyển đổi đại lý",
                        Name = "Chuyển đổi đại lý",
                        Content = "<p>Dear @agentName,</p>",

                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new EmailTemplateResponseModel {
                        EmailTemplateId = 3,
                        Creator = "admin",
                        EffectDate = DateTime.Now,
                        Subject = "Mail phản hồi liên hệ",
                        Name = "Mail phản hồi",
                        Content = "<p>Dear anh chị,</p>",

                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
        };
    }
}
