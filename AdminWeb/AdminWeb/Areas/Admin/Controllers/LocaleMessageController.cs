using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;

namespace AdminWeb.Areas.Admin.Controllers
{
    public class LocaleMessageController : BaseAdminController
    {
        private readonly IApiService _apiService;

        public LocaleMessageController(IApiService apiService)
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
        public object GetDataTableList(DataSourceLoadOptions loadOptions)
        {
            var _response = model;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        [HttpGet]
        public object GetLanguageListApi(DataSourceLoadOptions loadOptions)
        {
            var _response = modelLanguage;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<SysLocaleMessageResponseModel> model = new List<SysLocaleMessageResponseModel>()
        {
            new SysLocaleMessageResponseModel {
                        LocaleMessagesId = 1,
                        LanguageId = 1,
                        LanguageName = "Vietnamese",
                        MessageName = "Verify.Success",
                        MessageValue = "Xác thực thành công!",

                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new SysLocaleMessageResponseModel {
                        LocaleMessagesId = 1,
                        LanguageId = 1,
                        LanguageName = "Vietnamese",
                        MessageName = "Verify.Failed",
                        MessageValue = "Xác thực thất bại!",

                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new SysLocaleMessageResponseModel {
                        LocaleMessagesId = 1,
                        LanguageId = 1,
                        LanguageName = "Vietnamese",
                        MessageName = "Common.UpdateData.Successfully",
                        MessageValue = "Cập nhật dữ liệu thành công",

                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new SysLocaleMessageResponseModel {
                        LocaleMessagesId = 1,
                        LanguageId = 1,
                        LanguageName = "Vietnamese",
                        MessageName = "Common.UpdateData.Failed",
                        MessageValue = "Cập nhật dữ liệu thất bại",

                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
        };

        public static List<OsModel> modelLanguage = new List<OsModel>()
        {
            new OsModel
            {
                code = "1",
                name = "Vietnamese"
            },
            new OsModel
            {
                code = "2",
                name = "English"
            },
        };
    }
}
