using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{
    public class SalaryPeriodController : BaseCategoryController
    {
        private readonly IApiService _apiService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public SalaryPeriodController(IApiService apiService, IHttpContextAccessor httpContextAccessor)
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
                //_httpContextAccessor.HttpContext.Session.SetString("ActiveMenuItemSystemName", "SalaryPeriod");
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
        public object GetSalaryPeriodList(DataSourceLoadOptions loadOptions)
        {
            var _response = SalaryPeriodList;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<SalaryPeriodResponseModel> SalaryPeriodList = new List<SalaryPeriodResponseModel>()
        {

                 new SalaryPeriodResponseModel
                {
                    SalaryPeriodId = 1,
                    SalaryPeriodCode = "SLC05221",
                    SalaryPeriodType = "Full",
                    IsActive = true,
                    CreationDate = DateTime.Now,
                    CreatedBy = null,
                    LastUpdatedDate = DateTime.Now,
                    LastUpdatedBy = -1
                },
                 new SalaryPeriodResponseModel
                 {
                     SalaryPeriodId = 1,
                    SalaryPeriodCode = "SLC05241",
                    SalaryPeriodType = "Fresher",
                    IsActive = true,
                    CreationDate = DateTime.Now,
                    CreatedBy = null,
                    LastUpdatedDate = DateTime.Now,
                    LastUpdatedBy = -1
                 }
         
            #endregion
        };
    }
}
