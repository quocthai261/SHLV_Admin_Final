using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{
    public class FormulaController : BaseCategoryController
    {
        private readonly IApiService _apiService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public FormulaController(IApiService apiService, IHttpContextAccessor httpContextAccessor)
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
                //_httpContextAccessor.HttpContext.Session.SetString("ActiveMenuItemSystemName", "Formula");
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
        public object GetFormulaList(DataSourceLoadOptions loadOptions)
        {
            var _response = formulaList;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<FormulaResponseModel> formulaList = new List<FormulaResponseModel>()
        {
            new FormulaResponseModel
{
    FormulaId = 1,
    ValueOne = "&&",
    ValueTwo = "AND",
    Description = "Và",
    Type = 2,
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = 1,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = 1
},
new FormulaResponseModel
{
    FormulaId = 2,
    ValueOne = "||",
    ValueTwo = "OR",
    Description = "Hoặc",
    Type = 2,
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = 1,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = 1
},
new FormulaResponseModel
{
    FormulaId = 3,
    ValueOne = "<=",
    ValueTwo = "<=",
    Description = "Nhỏ hơn hoặc bằng",
    Type = 1,
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = 1,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = 1
},
new FormulaResponseModel
{
    FormulaId = 4,
    ValueOne = "=",
    ValueTwo = "=",
    Description = "Bằng",
    Type = 1,
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = 1,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = 1
},
new FormulaResponseModel
{
    FormulaId = 5,
    ValueOne = ">",
    ValueTwo = ">",
    Description = "Lớn hơn",
    Type = 1,
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = 1,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = 1
},
new FormulaResponseModel
{
    FormulaId = 6,
    ValueOne = ">=",
    ValueTwo = ">=",
    Description = "Lớn hơn hoặc bằng",
    Type = 1,
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = 1,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = 1
},
new FormulaResponseModel
{
    FormulaId = 7,
    ValueOne = "&&",
    ValueTwo = "AND",
    Description = "Và",
    Type = 2,
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = 1,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = 1
},
new FormulaResponseModel
{
    FormulaId = 8,
    ValueOne = "||",
    ValueTwo = "OR",
    Description = "Hoặc",
    Type = 2,
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = 1,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = 1
},
new FormulaResponseModel
{
    FormulaId = 9,
    ValueOne = "<=",
    ValueTwo = "<=",
    Description = "Nhỏ hơn hoặc bằng",
    Type = 1,
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = 1,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = 1
},
new FormulaResponseModel
{
    FormulaId = 10,
    ValueOne = "=",
    ValueTwo = "=",
    Description = "Bằng",
    Type = 1,
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = 1,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = 1
},
new FormulaResponseModel
{
    FormulaId = 11,
    ValueOne = ">",
    ValueTwo = ">",
    Description = "Lớn hơn",
    Type = 1,
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = 1,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = 1
},
new FormulaResponseModel
{
    FormulaId = 12,
    ValueOne = ">=",
    ValueTwo = ">=",
    Description = "Lớn hơn hoặc bằng",
    Type = 1,
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = 1,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = 1
},
new FormulaResponseModel
{
    FormulaId = 13,
    ValueOne = "<",
    ValueTwo = "<",
    Description = "Nhỏ hơn",
    Type = 1,
    IsActive = true,
    CreationDate = DateTime.Now,
    CreatedBy = 1,
    LastUpdatedDate = DateTime.Now,
    LastUpdatedBy = 1
}


        };

        #endregion
    }
}
