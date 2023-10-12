using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{
    public class PositionController : BaseCategoryController
    {
        private readonly IApiService _apiService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public PositionController(IApiService apiService, IHttpContextAccessor httpContextAccessor)
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
                //_httpContextAccessor.HttpContext.Session.SetString("ActiveMenuItemSystemName", "Position");
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
        public object GetPositionList(DataSourceLoadOptions loadOptions)
        {
            var _response = positionList;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<PositionResponseModel> positionList = new List<PositionResponseModel>()
        {
            new PositionResponseModel {
                        PositionId = 1,
                        PositionCode = "AG",
                        PositionName = "Tư vấn viên tài chính",
                        IsRegister = true,
                        IsApproval = true,
                        NextPosition = "RM",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new PositionResponseModel {
                        PositionId = 2,
                        PositionCode = "UM",
                        PositionName = "Quản lý ban KD",
                        IsRegister = true,
                        IsApproval = true,
                        NextPosition = "DM",
                        IsActive = false,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new PositionResponseModel {
                        PositionId = 3,
                        PositionCode = "DM",
                        PositionName = "Quản lý KVKD",
                        IsRegister = true,
                        IsApproval = true,
                        NextPosition = "SrDM",
                        IsActive = false,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
        };

        #endregion
    }
}
