using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{

    public class RegisterBfcStatusController : BaseCategoryController
    {
        private readonly IApiService _apiService;

        public RegisterBfcStatusController(IApiService apiService)
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
        public object GetRegisterBfcStatusList(DataSourceLoadOptions loadOptions)
        {
            var _response = registerBfcStatusList;

            return DataSourceLoader.Load(_response, loadOptions);
        }
        public static List<RegisterBfcStatusResponseModel> registerBfcStatusList = new List<RegisterBfcStatusResponseModel>()
        {
            new RegisterBfcStatusResponseModel
            {
                RegisterBfcStatusId = 1,
                RegisterBfcStatusCode = "RQ001",
                RegisterBfcStatusName = "Hồ sơ đã tạo",
                IsActive = true,
                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new RegisterBfcStatusResponseModel
            {
                RegisterBfcStatusId = 2,
                RegisterBfcStatusCode = "RQ002",
                RegisterBfcStatusName = "Hồ sơ đang chờ trưởng ban xét duyệt",
                IsActive = true,
                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new RegisterBfcStatusResponseModel
            {
                RegisterBfcStatusId = 3,
                RegisterBfcStatusCode = "RQ003",
                RegisterBfcStatusName = "Hồ sơ đang chờ Trưởng khu vực xét duyệt",
                IsActive = true,
                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
        };
    }
}
