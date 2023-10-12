using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Admin.Controllers
{
    public class IncomeController : BaseAdminController
    {
        private readonly IApiService _apiService;

        public IncomeController(IApiService apiService)
        {
            _apiService = apiService;
        }

        public IActionResult Index()
        {
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
