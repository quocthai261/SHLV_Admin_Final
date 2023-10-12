using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{
    public class DiagnosisCategoryController : BaseCategoryController
    {
        private readonly IApiService _apiService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public DiagnosisCategoryController(IApiService apiService, IHttpContextAccessor httpContextAccessor)
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
                //_httpContextAccessor.HttpContext.Session.SetString("ActiveMenuItemSystemName", "DiagnosisCategory");
                //_httpContextAccessor.HttpContext.Session.SetString("ActiveParentMenuSystemName", "Category");

                return View();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpGet]
        public object GetDiagnosisCategoryList(DataSourceLoadOptions loadOptions)
        {
            var _response = diagnosisCategoryList;

            return DataSourceLoader.Load(_response, loadOptions);
        }


        public static List<DiagnosisCategoryResponseModel> diagnosisCategoryList = new()
        {
            new DiagnosisCategoryResponseModel()
            {
                DiagnosisCategoryId = 1,
                CategoryDescription = "Khoa Tim mạch",
                IsActive=true,
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            },
            new DiagnosisCategoryResponseModel()
            {
                DiagnosisCategoryId = 2,
                CategoryDescription = "Khoa Nội Cơ-Xương-Khớp",
                IsActive=true,
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            },
            new DiagnosisCategoryResponseModel()
            {
                DiagnosisCategoryId = 3,
                CategoryDescription = "Khoa Sản phụ khoa",
                IsActive=true,
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            },
        };
    }
}
