using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{

    public class CustomerTypeController : BaseCategoryController
    {
        private readonly IApiService _apiService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CustomerTypeController(IApiService apiService, IHttpContextAccessor httpContextAccessor)
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
                //_httpContextAccessor.HttpContext.Session.SetString("ActiveMenuItemSystemName", "CustomerType");
                //_httpContextAccessor.HttpContext.Session.SetString("ActiveParentMenuSystemName", "Category");

                return View();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpGet]
        public object GetCustomerTypeList(DataSourceLoadOptions loadOptions)
        {
            var _response = customerTypeList;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<CustomerTypeResponseModel> customerTypeList = new List<CustomerTypeResponseModel>()
        {
            new CustomerTypeResponseModel()
            {
                CustomerTypeId = 1,
                CustomerTypeCode = "001",
                CustomerTypeName = "Khách hàng hiện hữu",
                IsActive=true,
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            },
             new CustomerTypeResponseModel()
            {
                CustomerTypeId = 2,
                CustomerTypeCode = "002",
                CustomerTypeName = "Khách hàng hiện hữu",
                IsActive=true,
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            },
              new CustomerTypeResponseModel()
            {
                CustomerTypeId = 3,
                CustomerTypeCode = "003",
                CustomerTypeName = "Khách hàng tiềm năng",
                IsActive=true,
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            },
        };
    }
}
