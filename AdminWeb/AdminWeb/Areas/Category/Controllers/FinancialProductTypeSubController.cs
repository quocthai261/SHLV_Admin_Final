using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{

    public class FinancialProductTypeSubController : BaseCategoryController
    {
        private readonly IApiService _apiService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public FinancialProductTypeSubController(IApiService apiService, IHttpContextAccessor httpContextAccessor)
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
                //_httpContextAccessor.HttpContext.Session.SetString("ActiveMenuItemSystemName", "FinancialProductTypeSub");
                //_httpContextAccessor.HttpContext.Session.SetString("ActiveParentMenuSystemName", "Category");

                return View();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpGet]
        public object GetFinancialProductTypeList(DataSourceLoadOptions loadOptions)
        {
            var _response = financialProductTypeList;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        [HttpGet]
        public object GetProductMainListApi(DataSourceLoadOptions loadOptions)
        {
            var _response = modelDistrict;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<OsModel> modelDistrict = new List<OsModel>()
        {
            new OsModel
            {
                code = "1",
                name = "Đầu tư thông minh"
            },
            new OsModel
            {
                code = "2",
                name = "Hưu trí tuổi vàng"
            },
            new OsModel
            {
                code = "3",
                name = "Học vấn cho con"
            },
            new OsModel
            {
                code = "4",
                name = "Học vấn cho con 2"
            },
        };

        public static List<FinancialProductTypeSubResponseModel> financialProductTypeList = new List<FinancialProductTypeSubResponseModel>()
        {
            new FinancialProductTypeSubResponseModel
            {
                FinProductTypeSubId = 1,
                ProductTypeCode ="DDTM",
                Image = "FinalcialDemandAnalysis/ProductType/DTTM.png",
                ProductTypeName = "Sub Đầu tư thông minh",
                ProductTypeMainName = "Đầu tư thông minh",
                Description = "Sub Đầu tư tài chính",
                IsActive=true,
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            },
            new FinancialProductTypeSubResponseModel
            {
                FinProductTypeSubId = 2,
                ProductTypeCode ="HTTV",
                Image = "FinalcialDemandAnalysis/ProductType/HTTV.png",
                ProductTypeName = "Sub Hưu trí tuổi vàng",
                ProductTypeMainName = "Hưu trí tuổi vàng",
                Description = "Sub Bảo vệ thu nhập cho tuổi vàng",
                IsActive=true,
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            },
            new FinancialProductTypeSubResponseModel
            {
                FinProductTypeSubId = 3,
                ProductTypeCode ="HVCC",
                Image = "FinalcialDemandAnalysis/ProductType/HVCC.png",
                ProductTypeName = "Sub Học vấn cho con",
                ProductTypeMainName = "Học vấn cho con",
                Description = "Sub Quý Giáo dục cho con yêu",
                IsActive=true,
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            },
        };
    }
}
