using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{
    public class ProvinceController : BaseCategoryController
    {
        private readonly IApiService _apiService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ProvinceController(IApiService apiService, IHttpContextAccessor httpContextAccessor)
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
                //_httpContextAccessor.HttpContext.Session.SetString("ActiveMenuItemSystemName", "Province");
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
        public object GetProvinceList(DataSourceLoadOptions loadOptions)
        {
            var _response = ProvinceList;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<ProvinceResponseModel> ProvinceList = new List<ProvinceResponseModel>()
        {
            new ProvinceResponseModel
            {
                ProvinceId = 1,
                ProvinceCode = "101",
                ProvinceName = "Hà Nội",
                IsActive = true,
                CreationDate = DateTime.Now,
                CreatedBy = null,
                LastUpdatedDate = DateTime.Now,
                LastUpdatedBy = -1
            },
            new ProvinceResponseModel
            {
                ProvinceId = 2,
                ProvinceCode = "401",
                ProvinceName = "Thanh Hóa",
                IsActive = true,
                CreationDate = DateTime.Now,
                CreatedBy = null,
                LastUpdatedDate = null,
                LastUpdatedBy = null
            },
            new ProvinceResponseModel
            {
                ProvinceId = 3,
                ProvinceCode = "701",
                ProvinceName = "Hồ Chí Minh",
                IsActive = true,
                CreationDate = DateTime.Now,
                CreatedBy = null,
                LastUpdatedDate = null,
                LastUpdatedBy = null
            },
            new ProvinceResponseModel
            {
                ProvinceId = 4,
                ProvinceCode = "403",
                ProvinceName = "Nghệ An",
                IsActive = true,
                CreationDate = DateTime.Now,
                CreatedBy = null,
                LastUpdatedDate = null,
                LastUpdatedBy = null
            },
            new ProvinceResponseModel
            {
                ProvinceId = 5,
                ProvinceCode = "501",
                ProvinceName = "Ðà Nẵng",
                IsActive = true,
                CreationDate = DateTime.Now,
                CreatedBy = null,
                LastUpdatedDate = null,
                LastUpdatedBy = null
            },
            new ProvinceResponseModel
            {
                ProvinceId = 6,
                ProvinceCode = "303",
                ProvinceName = "Sơn La",
                IsActive = true,
                CreationDate = DateTime.Now,
                CreatedBy = null,
                LastUpdatedDate = null,
                LastUpdatedBy = null
            },
            new ProvinceResponseModel
            {
                ProvinceId = 7,
                ProvinceCode = "811",
                ProvinceName = "Bến Tre",
                IsActive = true,
                CreationDate = DateTime.Now,
                CreatedBy = null,
                LastUpdatedDate = null,
                LastUpdatedBy = null
            },
            new ProvinceResponseModel
            {
                ProvinceId = 8,
                ProvinceCode = "213",
                ProvinceName = "Yên Bái",
                IsActive = true,
                CreationDate = DateTime.Now,
                CreatedBy = null,
                LastUpdatedDate = null,
                LastUpdatedBy = null
            },
            new ProvinceResponseModel
            {
                ProvinceId = 9,
                ProvinceCode = "713",
                ProvinceName = "Ðồng Nai",
                IsActive = true,
                CreationDate = DateTime.Now,
                CreatedBy = null,
                LastUpdatedDate = null,
                LastUpdatedBy = null
            },
            new ProvinceResponseModel
            {
                ProvinceId = 10,
                ProvinceCode = "106",
                ProvinceName = "Bắc Ninh",
                IsActive = true,
                CreationDate = DateTime.Now,
                CreatedBy = null,
                LastUpdatedDate = null,
                LastUpdatedBy = null
            },
            new ProvinceResponseModel
            {
                ProvinceId = 11,
                ProvinceCode = "507",
                ProvinceName = "Bình Ðịnh",
                IsActive = true,
                CreationDate = DateTime.Now,
                CreatedBy = null,
                LastUpdatedDate = null,
                LastUpdatedBy = null
            },
            new ProvinceResponseModel
            {
                ProvinceId = 12,
                ProvinceCode = "410",
                ProvinceName = "Hà Tây",
                IsActive = true,
                CreationDate = DateTime.Now,
                CreatedBy = null,
                LastUpdatedDate = null,
                LastUpdatedBy = null
            },
            new ProvinceResponseModel
            {
                ProvinceId = 13,
                ProvinceCode = "104",
                ProvinceName = "Vĩnh Phúc",
                IsActive = true,
                CreationDate = DateTime.Now,
                CreatedBy = null,
                LastUpdatedDate = null,
                LastUpdatedBy = null
            },
            new ProvinceResponseModel
            {
                ProvinceId = 14,
                ProvinceCode = "817",
                ProvinceName = "Trà Vinh",
                IsActive = true,
                CreationDate = DateTime.Now,
                CreatedBy = null,
                LastUpdatedDate = null,
                LastUpdatedBy = null
            },
            new ProvinceResponseModel
            {
                ProvinceId = 15,
                ProvinceCode = "709",
                ProvinceName = "Tây Ninh",
                IsActive = true,
                CreationDate = DateTime.Now,
                CreatedBy = null,
                LastUpdatedDate = null,
                LastUpdatedBy = null
            },
            new ProvinceResponseModel
            {
                ProvinceId = 16,
                ProvinceCode = "409",
                ProvinceName = "Quảng Trị",
                IsActive = true,
                CreationDate = DateTime.Now,
                CreatedBy = null,
                LastUpdatedDate = null,
                LastUpdatedBy = null
            },
            new ProvinceResponseModel
            {
                ProvinceId = 17,
                ProvinceCode = "405",
                ProvinceName = "Hà Tĩnh",
                IsActive = true,
                CreationDate = DateTime.Now,
                CreatedBy = null,
                LastUpdatedDate = null,
                LastUpdatedBy = null
            },
            new ProvinceResponseModel
            {
                ProvinceId = 18,
                ProvinceCode = "208",
                ProvinceName = "Lạng Sơn",
                IsActive = true,
                CreationDate = DateTime.Now,
                CreatedBy = null,
                LastUpdatedDate = null,
                LastUpdatedBy = null
            },
            new ProvinceResponseModel
            {
                ProvinceId = 19,
                ProvinceCode = "604",
                ProvinceName = "Đắk Nông",
                IsActive = true,
                CreationDate = DateTime.Now,
                CreatedBy = null,
                LastUpdatedDate = null,
                LastUpdatedBy = null
            },
            new ProvinceResponseModel
            {
                ProvinceId = 20,
                ProvinceCode = "103",
                ProvinceName = "Hải Phòng",
                IsActive = true,
                CreationDate = DateTime.Now,
                CreatedBy = null,
                LastUpdatedDate = null,
                LastUpdatedBy = null
            },
            new ProvinceResponseModel
            {
                ProvinceId = 21,
                ProvinceCode = "813",
                ProvinceName = "Kiên Giang",
                IsActive = true,
                CreationDate = DateTime.Now,
                CreatedBy = null,
                LastUpdatedDate = null,
                LastUpdatedBy = null
            },
            new ProvinceResponseModel
            {
                ProvinceId = 22,
                ProvinceCode = "603",
                ProvinceName = "Gia Lai",
                IsActive = true,
                CreationDate = DateTime.Now,
                CreatedBy = null,
                LastUpdatedDate = null,
                LastUpdatedBy = null
            },
            new ProvinceResponseModel
            {
                ProvinceId = 23,
                ProvinceCode = "823",
                ProvinceName = "Cà Mau",
                IsActive = true,
                CreationDate = DateTime.Now,
                CreatedBy = null,
                LastUpdatedDate = null,
                LastUpdatedBy = null
            },
            new ProvinceResponseModel
            {
                ProvinceId = 24,
                ProvinceCode = "815",
                ProvinceName = "Cần Thơ",
                IsActive = true,
                CreationDate = DateTime.Now,
                CreatedBy = null,
                LastUpdatedDate = null
            }

            #endregion
        };
    }
}
