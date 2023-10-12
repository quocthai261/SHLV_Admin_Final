using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{
    public class ReasonController : BaseCategoryController
    {
        private readonly IApiService _apiService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ReasonController(IApiService apiService, IHttpContextAccessor httpContextAccessor)
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
                //_httpContextAccessor.HttpContext.Session.SetString("ActiveMenuItemSystemName", "Reason");
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
        public object GetReasonList(DataSourceLoadOptions loadOptions)
        {
            var _response = reasonList;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<ReasonResponseModel> reasonList = new List<ReasonResponseModel>()
        {
            new ReasonResponseModel {
                        ReasonId = 1,
                        ReasonType = 1,
                        ReasonName = "Thiếu chứng từ",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new ReasonResponseModel {
                        ReasonId = 2,
                        ReasonType = 2,
                        ReasonName = "Không đủ điều kiện sức khỏe",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new ReasonResponseModel {
                        ReasonId = 3,
                        ReasonType = 3,
                        ReasonName = "Thiếu dữ liệu phân tích nhu cầu tài chính",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
        };

        #endregion
    }
}
