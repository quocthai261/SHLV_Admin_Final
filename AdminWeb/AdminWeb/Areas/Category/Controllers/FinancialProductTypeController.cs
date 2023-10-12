using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{

    public class FinancialProductTypeController : BaseCategoryController
    {
        private readonly IApiService _apiService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public FinancialProductTypeController(IApiService apiService, IHttpContextAccessor httpContextAccessor)
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
                //_httpContextAccessor.HttpContext.Session.SetString("ActiveMenuItemSystemName", "FinancialProductType");
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
        public object GetFinancialProductTypeChildList(long id, DataSourceLoadOptions loadOptions)
        {
            var _response = financialProductTypeList.Where(p => p.FinProductTypeId == id).First().lstChild;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<FinancialProductTypeResponseModel> financialProductTypeList = new List<FinancialProductTypeResponseModel>()
        {
            new FinancialProductTypeResponseModel
            {
                FinProductTypeId = 1,
                ProductTypeCode ="DDTM",
                Image = "FinalcialDemandAnalysis/ProductType/DTTM.png",
                ProductTypeName = "Đầu tư thông minh",
                Description = "Đầu tư tài chính",
                IsActive=true,
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
                lstChild = new List<FinancialProductTypeSubResponseModel>
                {
                    new FinancialProductTypeSubResponseModel
                    {
                        FinProductTypeSubId = 1,
                        ProductTypeCode ="DDTM",
                        Image = "FinalcialDemandAnalysis/ProductType/DTTM.png",
                        ProductTypeName = "Sub Đầu tư thông minh",
                        Description = "Sub Đầu tư tài chính",
                        IsActive=true,
                        CreationDate=DateTime.Now,
                        LastUpdatedDate=DateTime.Now,
                    }
                }
            },
            new FinancialProductTypeResponseModel
            {
                FinProductTypeId = 2,
                ProductTypeCode ="HTTV",
                Image = "FinalcialDemandAnalysis/ProductType/HTTV.png",
                ProductTypeName = "Hưu trí tuổi vàng",
                Description = "Bảo vệ thu nhập cho tuổi vàng",
                IsActive=true,
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
                lstChild = new List<FinancialProductTypeSubResponseModel>
                {
                    new FinancialProductTypeSubResponseModel
                    {
                        FinProductTypeSubId = 2,
                        ProductTypeCode ="DDTM",
                        Image = "FinalcialDemandAnalysis/ProductType/DTTM.png",
                        ProductTypeName = "Sub Hưu trí tuổi vàng",
                        Description = "Sub Hưu trí tuổi vàng",
                        IsActive=true,
                        CreationDate=DateTime.Now,
                        LastUpdatedDate=DateTime.Now,
                    }
                }
            },
            new FinancialProductTypeResponseModel
            {
                FinProductTypeId = 3,
                ProductTypeCode ="HVCC",
                Image = "FinalcialDemandAnalysis/ProductType/HVCC.png",
                ProductTypeName = "Học vấn cho con",
                Description = "Quý Giáo dục cho con yêu",
                IsActive=true,
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
                lstChild = new List<FinancialProductTypeSubResponseModel>
                {
                    new FinancialProductTypeSubResponseModel
                    {
                        FinProductTypeSubId = 3,
                        ProductTypeCode ="DDTM",
                        Image = "FinalcialDemandAnalysis/ProductType/DTTM.png",
                        ProductTypeName = "Sub Hưu trí tuổi vàng",
                        Description = "Sub Hưu trí tuổi vàng",
                        IsActive=true,
                        CreationDate=DateTime.Now,
                        LastUpdatedDate=DateTime.Now,
                    }
                }
            },
        };
    }
}
