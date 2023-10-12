using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{
    public class ProDeCriteriaController : BaseCategoryController
    {
        private readonly IApiService _apiService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ProDeCriteriaController(IApiService apiService, IHttpContextAccessor httpContextAccessor)
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
                //_httpContextAccessor.HttpContext.Session.SetString("ActiveMenuItemSystemName", "ProDeCriteria");
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
        public object GetProDeCriteriaList(DataSourceLoadOptions loadOptions)
        {
            var _response = proDeCriteria;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<ProDeCriteriaResponseModel> proDeCriteria = new List<ProDeCriteriaResponseModel>()
        {
            new ProDeCriteriaResponseModel
{
    ProDeCriteriaId = 1,
    Title = "Tổng IFYP trong tháng gia nhập",
    Code = "IFYP",
    Unit = "VND",
    Icon = null,
    EndPoint = "API",
    ProcessColor = "#40A9FF",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = 1,
    LastUpdatedDate = null,
    LastUpdatedBy = null
},
new ProDeCriteriaResponseModel
{
    ProDeCriteriaId = 2,
    Title = "Lượt FC hoạt động",
    Code = "FCActive",
    Unit = "Số lượng",
    Icon = null,
    EndPoint = "API",
    ProcessColor = "#0FD2D2",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = 1,
    LastUpdatedDate = null,
    LastUpdatedBy = null
},
new ProDeCriteriaResponseModel
{
    ProDeCriteriaId = 3,
    Title = "Lượt FC hoạt động trong KVKD",
    Code = "ActiveInDirectDistrict",
    Unit = "Số lượng",
    Icon = "CriteriaIcons/5681f680-37a0-4e1d-8a71-e03520b95b3b.png",
    EndPoint = "API",
    ProcessColor = "#40A9FF",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = 1,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = 1
},
new ProDeCriteriaResponseModel
{
    ProDeCriteriaId = 4,
    Title = "Số ban phát triển nội bộ",
    Code = "InternalBM",
    Unit = "Số lượng",
    Icon = "CriteriaIcons/5bcd054e-9722-41ca-a018-c74bd18f9793.png",
    EndPoint = "API",
    ProcessColor = "#0FD2D2",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = 1,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = 1
},
new ProDeCriteriaResponseModel
{
    ProDeCriteriaId = 5,
    Title = "Tổng số ban trực thuộc",
    Code = "NoOfUnderBM",
    Unit = "Số lượng",
    Icon = "CriteriaIcons/c0cb9db9-71aa-4ca2-835a-815caf4181af.png",
    EndPoint = "API",
    ProcessColor = "#0FD2D2",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = 1,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = 1
},
new ProDeCriteriaResponseModel
{
    ProDeCriteriaId = 6,
    Title = "Tổng lượt FC hoạt động",
    Code = "TeamActive",
    Unit = "Số lượng",
    Icon = "CriteriaIcons/ed6e3aed-2d81-4f5f-bdb2-2c82091ee010.png",
    EndPoint = "API",
    ProcessColor = "#0FD2D2",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = 1,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = 1
},
new ProDeCriteriaResponseModel
{
    ProDeCriteriaId = 7,
    Title = "Số tháng làm việc",
    Code = "MonthActive",
    Unit = "Số lượng",
    Icon = null,
    EndPoint = "API",
    ProcessColor = "#40A9FF",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = 1,
    LastUpdatedDate = null,
    LastUpdatedBy = null
},
new ProDeCriteriaResponseModel
{
    ProDeCriteriaId = 8,
    Title = "Lượt FC mới hoạt động",
    Code = "ActiveRecruit",
    Unit = "Số lượng",
    Icon = "CriteriaIcons/7e41095f-67c9-415b-9c36-565f8ddf5236.png",
    EndPoint = "API",
    ProcessColor = "#0FD2D2",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = 1,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = 1
},
new ProDeCriteriaResponseModel
{
    ProDeCriteriaId = 9,
    Title = "Lượt hoạt động cá nhân",
    Code = "PersonalActive",
    Unit = "Số lượng",
    Icon = "CriteriaIcons/d96bf5cb-589f-4d73-8db6-292ee8350269.png",
    EndPoint = "API",
    ProcessColor = "#40A9FF",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = 1,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = 1
},
new ProDeCriteriaResponseModel
{
    ProDeCriteriaId = 10,
    Title = "Lượt FC hoạt động trong Ban KD",
    Code = "ActiveInDirectUnit",
    Unit = "Số lượng",
    Icon = "CriteriaIcons/9aff38d2-3307-428d-adba-4c95d388be41.png",
    EndPoint = "API",
    ProcessColor = "#0FD2D2",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = 1,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = 1
},
new ProDeCriteriaResponseModel
{
    ProDeCriteriaId = 11,
    Title = "Phí cá nhân",
    Code = "PersonalFYP",
    Unit = "VND",
    Icon = "CriteriaIcons/498a4b77-e777-4a0b-9408-0945f01ec7e0.png",
    EndPoint = "API",
    ProcessColor = "#40A9FF",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = 1,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = 1
},
new ProDeCriteriaResponseModel
{
    ProDeCriteriaId = 12,
    Title = "Tỷ lệ duy trì hợp đồng năm 2 cá nhân",
    Code = "K2",
    Unit = "%",
    Icon = "CriteriaIcons/83d5133f-9ad1-4dd2-96eb-2cb90ccb64eb.png",
    EndPoint = "API",
    ProcessColor = "#0FD2D2",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = 1,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = 1
},
new ProDeCriteriaResponseModel
{
    ProDeCriteriaId = 13,
    Title = "Lượt FC mới hoạt động trong nhóm",
    Code = "TeamActiveRecruit",
    Unit = "Số lượng",
    Icon = "CriteriaIcons/333c55c3-c35e-4013-b2c7-8221951838d7.png",
    EndPoint = "API",
    ProcessColor = "#40A9FF",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = 1,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = 1
},
new ProDeCriteriaResponseModel
{
    ProDeCriteriaId = 14,
    Title = "Tỷ lệ duy trì hợp đồng năm 2 của DM",
    Code = "K2DM",
    Unit = "%",
    Icon = null,
    EndPoint = "API",
    ProcessColor = "#0FD2D2",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = 1,
    LastUpdatedDate = null,
    LastUpdatedBy = null
},
new ProDeCriteriaResponseModel
{
    ProDeCriteriaId = 15,
    Title = "Tỷ lệ duy trì hợp đồng năm 2 của UM",
    Code = "K2UM",
    Unit = "%",
    Icon = null,
    EndPoint = "API",
    ProcessColor = "#0FD2D2",
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = 1,
    LastUpdatedDate = null,
    LastUpdatedBy = null
}

        };
        public static string[] unitList = new[] {
            "%",
            "VND",
            "Số lượng"
        };
        [HttpGet]
        public object GetUnitList(DataSourceLoadOptions loadOptions)
        {
            var _response = unitList;

            return DataSourceLoader.Load(_response, loadOptions);
        }
        #endregion
    }
}
