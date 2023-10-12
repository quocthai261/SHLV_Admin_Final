using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{
    public class PremiumStatusController : BaseCategoryController
    {
        private readonly IApiService _apiService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public PremiumStatusController(IApiService apiService, IHttpContextAccessor httpContextAccessor)
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
                //_httpContextAccessor.HttpContext.Session.SetString("ActiveMenuItemSystemName", "PremiumStatus");
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


        public static List<PremiumStatusResponseModel> model = new List<PremiumStatusResponseModel>()
        {
            new PremiumStatusResponseModel {
                        PremiumStatusId = 1,
                        PremiumStatusName = "Regular",
                        PremiumStatusNameVN = "Định kỳ",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new PremiumStatusResponseModel {
                        PremiumStatusId = 2,
                        PremiumStatusName = "Fully Paid",
                        PremiumStatusNameVN = "Hoàn tất",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new PremiumStatusResponseModel {
                        PremiumStatusId = 3,
                        PremiumStatusName = "Reduced Paid-Up",
                        PremiumStatusNameVN = "Dừng đóng phí với số tiền bảo hiểm giảm",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new PremiumStatusResponseModel {
                        PremiumStatusId = 4,
                        PremiumStatusName = "Premium Waived",
                        PremiumStatusNameVN = "Miễn đóng phí",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
        };
    }
}
