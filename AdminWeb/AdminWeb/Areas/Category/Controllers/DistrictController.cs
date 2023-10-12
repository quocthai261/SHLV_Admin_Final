using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{
    public class DistrictController : BaseCategoryController
    {
        private readonly IApiService _apiService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public DistrictController(IApiService apiService, IHttpContextAccessor httpContextAccessor)
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
                //_httpContextAccessor.HttpContext.Session.SetString("ActiveMenuItemSystemName", "District");
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

        [HttpGet]
        public object GetProvinceListApi(DataSourceLoadOptions loadOptions)
        {
            var _response = modelProvince;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<OsModel> modelProvince = new List<OsModel>()
        {
            new OsModel
            {
                code = "1",
                name = "Hồ Chí Minh"
            },
            new OsModel
            {
                code = "2",
                name = "Hà Nội"
            },
            new OsModel
            {
                code = "3",
                name = "Nha Trang"
            },
            new OsModel
            {
                code = "4",
                name = "Nam Định"
            },
        };


        public static List<DistrictResponseModel> model = new List<DistrictResponseModel>()
        {
            new DistrictResponseModel {
                        DistrictId = 1,
                        ProvinceId = 1,
                        ProvinceName = "Hồ Chí Minh",
                        DistrictName = "Thủ Đức",
                        DistrictCode = "1",

                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new DistrictResponseModel {
                        DistrictId = 2,
                        ProvinceId = 1,
                        ProvinceName = "Hồ Chí Minh",
                        DistrictName = "Phú Nhuận",
                        DistrictCode = "2",

                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new DistrictResponseModel {
                        DistrictId = 3,
                        ProvinceId = 1,
                        ProvinceName = "Hồ Chí Minh",
                        DistrictName = "Quận 1",
                        DistrictCode = "4",

                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
        };
    }
}
