using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{

    public class AgentMoveTypesController : BaseCategoryController
    {
        private readonly IApiService _apiService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AgentMoveTypesController(IApiService apiService, IHttpContextAccessor httpContextAccessor)
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
                //_httpContextAccessor.HttpContext.Session.SetString("ActiveMenuItemSystemName", "AgentMoveTypes");
                //_httpContextAccessor.HttpContext.Session.SetString("ActiveParentMenuSystemName", "Category");

                return View();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpGet]
        public object GetAgentMoveTypesList(DataSourceLoadOptions loadOptions)
        {
            var _response = agentMoveTypesList;

            return DataSourceLoader.Load(_response, loadOptions);
        }
        public static List<AgentMoveTypesResponseModel> agentMoveTypesList = new List<AgentMoveTypesResponseModel>()
        {
            new AgentMoveTypesResponseModel
            {
                AgentMoveTypeId = 1,
                TypeCode = "M1",
                TypeName = "Chuyển ban KD",
                Description = "Chuyển ban kinh doanh",
                IsActive=true,
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            },
            new AgentMoveTypesResponseModel
            {
                AgentMoveTypeId = 2,
                TypeCode = "M2",
                TypeName = "Chuyển ban KVKD",
                Description = "Chuyển ban khu vực kinh doanh",
                IsActive=true,
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            },
            new AgentMoveTypesResponseModel
            {
                AgentMoveTypeId = 1,
                TypeCode = "M3",
                TypeName = "Chuyển ban VPKD",
                Description = "Chuyển ban văn phòng kinh doanh",
                IsActive=true,
                CreationDate=DateTime.Now,
                LastUpdatedDate=DateTime.Now,
            },
        };
    }
}
