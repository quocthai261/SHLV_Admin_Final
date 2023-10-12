using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{
    public class ClaimStatusController : BaseCategoryController
    {
        private readonly IApiService _apiService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ClaimStatusController(IApiService apiService, IHttpContextAccessor httpContextAccessor)
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
                //_httpContextAccessor.HttpContext.Session.SetString("ActiveMenuItemSystemName", "ClaimStatus");
                //_httpContextAccessor.HttpContext.Session.SetString("ActiveParentMenuSystemName", "Category");

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


        public static List<ClaimStatusResponseModel> model = new List<ClaimStatusResponseModel>()
        {
            new ClaimStatusResponseModel {
                        ClaimStatusId = 1,
                        ClaimStatusName = "Admit",
                        ClaimStatusNameVN = "Chấp nhận bồi thường",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new ClaimStatusResponseModel {
                        ClaimStatusId = 2,
                        ClaimStatusName = "Withdrawn",
                        ClaimStatusNameVN = "Tạm đóng hồ sơ",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new ClaimStatusResponseModel {
                        ClaimStatusId = 3,
                        ClaimStatusName = "Decline",
                        ClaimStatusNameVN = "Từ chối bồi thường",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new ClaimStatusResponseModel {
                        ClaimStatusId = 4,
                        ClaimStatusName = "Ex-Gratia-Partial",
                        ClaimStatusNameVN = "Chi trả khác",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
        };
    }
}
