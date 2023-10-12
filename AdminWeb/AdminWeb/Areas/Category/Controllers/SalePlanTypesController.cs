using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{
    public class SalePlanTypesController : BaseCategoryController
    {
        private readonly IApiService _apiService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public SalePlanTypesController(IApiService apiService, IHttpContextAccessor httpContextAccessor)
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
                //_httpContextAccessor.HttpContext.Session.SetString("ActiveMenuItemSystemName", "SalePlanTypes");
                //_httpContextAccessor.HttpContext.Session.SetString("ActiveParentMenuSystemName", "Category");

                return View();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public object GetSalePlanTypesList(DataSourceLoadOptions loadOptions)
        {
            var _response = salePlanTypesList;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<SalePlanTypesResponseModel> salePlanTypesList = new List<SalePlanTypesResponseModel>()
        {
            new SalePlanTypesResponseModel()
            {
                SalePlanTypesId = 1,
                Title = "Hội thảo",
                Code = "HoiThao",
                IsActive = true,
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            },
             new SalePlanTypesResponseModel()
            {
                SalePlanTypesId = 2,
                Title = "Kế hoạch kinh doanh",
                Code = "KHKD",
                IsActive = true,
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            }
        };

        [HttpGet]
        public object GetChiTieuKHKDList(DataSourceLoadOptions loadOptions)
        {
            var _response = chiTieuKHKDTheoViTri;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<ChiTieuKHKDModel> chiTieuKHKDTheoViTri = new List<ChiTieuKHKDModel>()
        {
            new ChiTieuKHKDModel()
            {
                Id = 1,
                Code = "CandidateIntroduction",
                Name = "Giới thiệu ứng viên"
            },
            new ChiTieuKHKDModel()
            {
                Id = 2,
                Code = "PolicyNumber",
                Name = "Số lượng hợp đồng"
            },
            new ChiTieuKHKDModel()
            {
                Id = 3,
                Code = "K2",
                Name = "Tỷ lệ duy trì K2"
            },
            new ChiTieuKHKDModel()
            {
                Id = 4,
                Code = "FYP",
                Name = "FYP (VNĐ)"
            },
            new ChiTieuKHKDModel()
            {
                Id = 5,
                Code = "OperationNumber",
                Name = "Lượng hoạt động"
            },
            new ChiTieuKHKDModel()
            {
                Id = 6,
                Code = "RecruitmentNumber",
                Name = "Lượng tuyển dụng"
            },
            new ChiTieuKHKDModel()
            {
                Id = 7,
                Code = "AFYP",
                Name = "AFYP"
            },
        };
    }

    public class ChiTieuKHKDModel
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }
    }
}
