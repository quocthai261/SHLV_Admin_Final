using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{
    public class NationalitiesController : BaseCategoryController
    {
        private readonly IApiService _apiService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public NationalitiesController(IApiService apiService, IHttpContextAccessor httpContextAccessor)
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
                //_httpContextAccessor.HttpContext.Session.SetString("ActiveMenuItemSystemName", "Nationalities");
                //_httpContextAccessor.HttpContext.Session.SetString("ActiveParentMenuSystemName", "Category");

                return View();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region -- Methods --

        [HttpGet]
        public object GetNationalityList(DataSourceLoadOptions loadOptions)
        {
            var _response = NationalityList;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<NationalitiesResponseModel> NationalityList = new List<NationalitiesResponseModel>()
        {
            new NationalitiesResponseModel
            {
                NationalityId = 1,
                NationalityCode = "VN",
                NationalityName = "Việt Nam",
                IsActive = true,
                CreationDate = DateTime.Now,
                CreatedBy = null,
                LastUpdatedDate = DateTime.Now,
                LastUpdatedBy = 1
            },
            new NationalitiesResponseModel
            {
                NationalityId = 2,
                NationalityCode = "LA",
                NationalityName = "America",
                IsActive = true,
                CreationDate = DateTime.Now,
                CreatedBy = null,
                LastUpdatedDate = null,
                LastUpdatedBy = null
            },
            new NationalitiesResponseModel
            {
                NationalityId = 3,
                NationalityCode = "AUS",
                NationalityName = "Úc",
                IsActive = true,
                CreationDate = DateTime.Now,
                CreatedBy = null,
                LastUpdatedDate = null,
                LastUpdatedBy = null
            }

            #endregion
        };
    }
}
