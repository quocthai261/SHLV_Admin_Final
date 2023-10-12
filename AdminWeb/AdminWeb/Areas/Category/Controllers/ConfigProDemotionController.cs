using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{
    public class ConfigProDemotionController : BaseCategoryController
    {
        private readonly IApiService _apiService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ConfigProDemotionController(IApiService apiService, IHttpContextAccessor httpContextAccessor)
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
                //_httpContextAccessor.HttpContext.Session.SetString("ActiveMenuItemSystemName", "ConfigProDemotion");
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
        public object GetConfigProDemotionList(DataSourceLoadOptions loadOptions)
        {
            var _response = configProDemotionList;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<ConfigProDemotionResponseModel> configProDemotionList = new List<ConfigProDemotionResponseModel>()
        {
  new ConfigProDemotionResponseModel
  {
      ConfigProDemotionID = 39,
      ConfigProDemotionCode = "RM",
      ApplyDate = DateTime.Now,
      ConfigType = 2,
      IsActive=true,
      CreationDate = DateTime.Now,
      CreatedBy = null,
      LastUpdatedDate = DateTime.Now,
      LastUpdatedDateBy = null,
      PeriodReview = 1
  },
  new ConfigProDemotionResponseModel
  {
      ConfigProDemotionID = 40,
      ConfigProDemotionCode = "UM",
      ApplyDate = DateTime.Now,
      ConfigType = 2,
      IsActive=true,
      CreationDate = DateTime.Now,
      CreatedBy = null,
      LastUpdatedDate = DateTime.Now,
      LastUpdatedDateBy = null,
      PeriodReview = 2
  },
  new ConfigProDemotionResponseModel
  {
      ConfigProDemotionID = 36,
      ConfigProDemotionCode = "UM",
      ApplyDate = DateTime.Now,
      ConfigType = 1,
      IsActive=true,
      CreationDate = DateTime.Now,
      CreatedBy = null,
      LastUpdatedDate = DateTime.Now,
      LastUpdatedDateBy = null,
      PeriodReview = 2
  },
  new ConfigProDemotionResponseModel
  {
      ConfigProDemotionID = 35,
      ConfigProDemotionCode = "SrDM",
      ApplyDate = DateTime.Now,
      ConfigType = 1,
      IsActive=true,
      CreationDate = DateTime.Now,
      CreatedBy = null,
      LastUpdatedDate = DateTime.Now,
      LastUpdatedDateBy = null,
      PeriodReview = 4
  },
  new ConfigProDemotionResponseModel
  {
      ConfigProDemotionID = 41,
      ConfigProDemotionCode = "DM",
      ApplyDate = DateTime.Now,
      ConfigType = 2,
      IsActive=true,
      CreationDate = DateTime.Now,
      CreatedBy = null,
      LastUpdatedDate = DateTime.Now,
      LastUpdatedDateBy = null,
      PeriodReview = 3
  },
  new ConfigProDemotionResponseModel
  {
      ConfigProDemotionID = 37,
      ConfigProDemotionCode = "RM",
      ApplyDate = DateTime.Now,
      ConfigType = 1,
      IsActive=true,
      CreationDate = DateTime.Now,
      CreatedBy = null,
      LastUpdatedDate = DateTime.Now,
      LastUpdatedDateBy = null,
      PeriodReview = 1
  },
  new ConfigProDemotionResponseModel
  {
      ConfigProDemotionID = 38,
      ConfigProDemotionCode = "DM",
      ApplyDate = DateTime.Now,
      ConfigType = 1,
      IsActive=true,
      CreationDate = DateTime.Now,
      CreatedBy = null,
      LastUpdatedDate = DateTime.Now,
      LastUpdatedDateBy = null,
      PeriodReview = 2
  },
  new ConfigProDemotionResponseModel
  {
      ConfigProDemotionID = 42,
      ConfigProDemotionCode = "HrDM",
      ApplyDate = DateTime.Now,
      ConfigType = 2,
      IsActive=true,
      CreationDate = DateTime.Now,
      CreatedBy = null,
      LastUpdatedDate = DateTime.Now,
      LastUpdatedDateBy = null,
      PeriodReview = 3
  },
  new ConfigProDemotionResponseModel
  {
      ConfigProDemotionID = 43,
      ConfigProDemotionCode = "SrDM",
      ApplyDate = DateTime.Now,
      ConfigType = 2,
      IsActive=true,
      CreationDate = DateTime.Now,
      CreatedBy = null,
      LastUpdatedDate = DateTime.Now,
      LastUpdatedDateBy = null,
      PeriodReview = 4
  },
  new ConfigProDemotionResponseModel
  {
      ConfigProDemotionID = 34,
      ConfigProDemotionCode = "SrUM",
      ApplyDate = DateTime.Now,
      ConfigType = 1,
      IsActive=true,
      CreationDate = DateTime.Now,
      CreatedBy = null,
      LastUpdatedDate = DateTime.Now,
      LastUpdatedDateBy = null,
      PeriodReview = 2
  }
            #endregion
        };
    }
}
