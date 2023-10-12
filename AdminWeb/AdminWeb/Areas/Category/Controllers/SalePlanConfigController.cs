using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{
    public class SalePlanConfigController : BaseCategoryController
    {
        private readonly IApiService _apiService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public SalePlanConfigController(IApiService apiService, IHttpContextAccessor httpContextAccessor)
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
                //_httpContextAccessor.HttpContext.Session.SetString("ActiveMenuItemSystemName", "SalePlanConfig");
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
        public object GetSalePlanConfigList(DataSourceLoadOptions loadOptions)
        {
            var _response = salePlanConfig;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<SalePlanConfigResponseModel> salePlanConfig = new List<SalePlanConfigResponseModel>()
        {
            new SalePlanConfigResponseModel {
                        SalePlanConfigId = 1,
                        PositionCode = "AG",
                        AllowCreateDay = 27,
                        AllowEditDay = 29,
                        PlanType = 1,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
            },
            new SalePlanConfigResponseModel {
                        SalePlanConfigId = 2,
                        PositionCode = "AG",
                        AllowCreateDay = 15,
                        AllowEditDay = 17,
                        PlanType = 2,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new SalePlanConfigResponseModel {
                        SalePlanConfigId = 3,
                        PositionCode = "DM",
                        AllowCreateDay = 27,
                        AllowEditDay = 29,
                        PlanType = 2,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
        };

        public IEnumerable<SalePlanConfigDetailResponseModel> GetSalePlanConfigDetailList(int id)
        {
            return salePlanConfigDetailList.Where(e => e.SalePlanConfigId == id);
        }

        public static List<SalePlanConfigDetailResponseModel> salePlanConfigDetailList = new List<SalePlanConfigDetailResponseModel>()
        {
            new SalePlanConfigDetailResponseModel()
            {
                SalePlanConfigDetailId = 1,
                SalePlanConfigId = 1,
                ChiTieuKHKD = "CandidateIntroduction",
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            },
            new SalePlanConfigDetailResponseModel()
            {
                SalePlanConfigDetailId = 2,
                SalePlanConfigId = 1,
                ChiTieuKHKD = "PolicyNumber",
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            },
            new SalePlanConfigDetailResponseModel()
            {
                SalePlanConfigDetailId = 3,
                SalePlanConfigId = 2,
                ChiTieuKHKD = "PolicyNumber",
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            },
            new SalePlanConfigDetailResponseModel()
            {
                SalePlanConfigDetailId = 4,
                SalePlanConfigId = 2,
                ChiTieuKHKD = "K2",
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            },
            new SalePlanConfigDetailResponseModel()
            {
                SalePlanConfigDetailId = 5,
                SalePlanConfigId = 3,
                ChiTieuKHKD = "FYP",
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            },
            new SalePlanConfigDetailResponseModel()
            {
                SalePlanConfigDetailId = 6,
                SalePlanConfigId = 3,
                ChiTieuKHKD = "OperationNumber",
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            },
        };

        #endregion
    }
}
