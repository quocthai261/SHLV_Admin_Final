using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Admin.Controllers
{
    public class LanguageController : BaseAdminController
    {
        private readonly IApiService _apiService;

        public LanguageController(IApiService apiService)
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

        public static List<SysLanguageResponseModel> model = new List<SysLanguageResponseModel>()
        {
            new SysLanguageResponseModel {
                        LanguageId = 1,
                        LanguageCulture = "vi",
                        DisplayOrder = 1,
                        FlagImageFileName = "vn.png",
                        Name = "Vietnamese",

                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new SysLanguageResponseModel {
                        LanguageId = 2,
                        LanguageCulture = "eng",
                        DisplayOrder = 2,
                        FlagImageFileName = "eng.png",
                        Name = "English",

                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
        };
    }
}
