using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{
    public class MarriageController : BaseCategoryController
    {
        private readonly IApiService _apiService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public MarriageController(IApiService apiService, IHttpContextAccessor httpContextAccessor)
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
                //_httpContextAccessor.HttpContext.Session.SetString("ActiveMenuItemSystemName", "Marriage");
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
        public object GetMarriageList(DataSourceLoadOptions loadOptions)
        {
            var _response = reasonList;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<MarriageResponseModel> reasonList = new List<MarriageResponseModel>()
        {
            new MarriageResponseModel {
                        MarriageId = 1,
                        MarriageName = "Độc thân",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now
                    },
            new MarriageResponseModel {
                        MarriageId = 2,
                        MarriageName = "Đã kết hôn",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now
                    },
            new MarriageResponseModel {
                        MarriageId = 3,
                        MarriageName = "Ly thân",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now
                    },
        };

        #endregion
    }
}
