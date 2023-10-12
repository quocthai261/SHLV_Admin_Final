using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{
    public class CareerController : BaseCategoryController
    {
        private readonly IApiService _apiService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CareerController(IApiService apiService, IHttpContextAccessor httpContextAccessor)
        {
            _apiService = apiService;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            //_httpContextAccessor.HttpContext.Session.SetString("ActiveMenuItemSystemName", "Career");
            //_httpContextAccessor.HttpContext.Session.SetString("ActiveParentMenuSystemName", "Category");

            return RedirectToAction("List");
        }

        public IActionResult List()
        {
            try
            {
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

        public static List<CareerResponseModel> model = new List<CareerResponseModel>()
        {
            new CareerResponseModel {
                        CareerId = 1,
                        CareerCode = "23",
                        CareerName = "Bác sỹ",

                        CreationDate = DateTime.Now,
                    },
           new CareerResponseModel {
                        CareerId = 1,
                        CareerCode = "24",
                        CareerName = "Kỹ sư",

                        CreationDate = DateTime.Now,
                    },
            new CareerResponseModel {
                        CareerId = 1,
                        CareerCode = "25",
                        CareerName = "Nhà báo",

                        CreationDate = DateTime.Now,
                    },
        };
    }
}
