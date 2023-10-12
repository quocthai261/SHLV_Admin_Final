using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{
    public class WardController : BaseCategoryController
    {
        private readonly IApiService _apiService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public WardController(IApiService apiService, IHttpContextAccessor httpContextAccessor)
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
                //_httpContextAccessor.HttpContext.Session.SetString("ActiveMenuItemSystemName", "Ward");
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
        public object GetDistrictListApi(DataSourceLoadOptions loadOptions)
        {
            var _response = modelDistrict;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<OsModel> modelDistrict = new List<OsModel>()
        {
            new OsModel
            {
                code = "1",
                name = "Thủ Đức"
            },
            new OsModel
            {
                code = "2",
                name = "Phú Nhuận"
            },
            new OsModel
            {
                code = "3",
                name = "Quận 1"
            },
            new OsModel
            {
                code = "4",
                name = "Quận 2"
            },
        };

        public static List<WardResponseModel> model = new List<WardResponseModel>()
        {
            new WardResponseModel {
                        WardId = 1,
                        WardCode = "26734",
                        WardName = "Tân Định",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new WardResponseModel {
                        WardId = 2,
                        WardCode = "26740",
                        WardName = "Bến Nghé",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new WardResponseModel {
                        WardId = 3,
                        WardCode = "26743",
                        WardName = "Bến Thành",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new WardResponseModel {
                        WardId = 4,
                        WardCode = "26818",
                        WardName = "Linh Tây",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
        };
    }
}
