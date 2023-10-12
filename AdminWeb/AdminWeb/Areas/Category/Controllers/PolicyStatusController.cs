using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{
    public class PolicyStatusController : BaseCategoryController
    {
        private readonly IApiService _apiService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public PolicyStatusController(IApiService apiService, IHttpContextAccessor httpContextAccessor)
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
                //_httpContextAccessor.HttpContext.Session.SetString("ActiveMenuItemSystemName", "PolicyStatus");
                //_httpContextAccessor.HttpContext.Session.SetString("ActiveParentMenuSystemName", "Category");

                return View();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpGet]
        public object GetPolicyStatusList(DataSourceLoadOptions loadOptions)
        {
            var _response = policyStatusList;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<PolicyStatusResponseModel> policyStatusList = new List<PolicyStatusResponseModel>()
        {
            new PolicyStatusResponseModel
            {
                PolicyStatusId = 1,
                PolicyStatusCode="085",
                PolicyStatusName="Đến hạn đóng phí",
                IsActive=false,
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            },
            new PolicyStatusResponseModel
            {
                PolicyStatusId = 2,
                PolicyStatusCode="CNL02",
                PolicyStatusName="Hồ sơ tạm hoãn bảo hiểm",
                IsActive=true,
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            },
            new PolicyStatusResponseModel
            {
                PolicyStatusId = 3,
                PolicyStatusCode="009",
                PolicyStatusName="Đã hủy",
                IsActive=true,
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            }
        };

    }
}
