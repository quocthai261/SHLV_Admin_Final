using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{
    public class PositionApplingsController : BaseCategoryController
    {
        private readonly IApiService _apiService;

        public PositionApplingsController(IApiService apiService)
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
        public object GetPositionApplingsList(DataSourceLoadOptions loadOptions)
        {
            var _response = positionApplingsList;

            return DataSourceLoader.Load(_response, loadOptions);
        }
        public static List<PositionApplingsResponseModel> positionApplingsList = new List<PositionApplingsResponseModel>()
        {
            new PositionApplingsResponseModel()
            {
                PositionApplingsId = 1,
                PositionApplingCode = "360",
                PositionApplingName = "Quản lý",
                IsActive = true,
                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
               new PositionApplingsResponseModel()
            {
                PositionApplingsId = 2,
                PositionApplingCode = "251",
                PositionApplingName = "Nhân viên",
                IsActive = true,
                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
                  new PositionApplingsResponseModel()
            {
                PositionApplingsId = 3,
                PositionApplingCode = "365",
                PositionApplingName = "Trợ lý",
                IsActive = false,
                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
        };
    }
}
