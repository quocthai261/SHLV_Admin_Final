using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Category.Controllers
{
    public class IncomeController : BaseCategoryController
    {
        private readonly IApiService _apiService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public IncomeController(IApiService apiService, IHttpContextAccessor httpContextAccessor)
        {
            _apiService = apiService;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            //_httpContextAccessor.HttpContext.Session.SetString("ActiveMenuItemSystemName", "Income");
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

        public static List<IncomeResponseModel> model = new List<IncomeResponseModel>()
        {
            new IncomeResponseModel {
                        IncomeId = 1,
                        IncomeCode = "23",
                        IncomeName = "Lương",

                        CreationDate = DateTime.Now,
                    },
            new IncomeResponseModel {
                        IncomeId = 2,
                        IncomeCode = "24",
                        IncomeName = "Kinh doanh",

                        CreationDate = DateTime.Now,
                    },
            new IncomeResponseModel {
                        IncomeId = 3,
                        IncomeCode = "25",
                        IncomeName = "Khác",

                        CreationDate = DateTime.Now,
                    },
        };
    }
}
