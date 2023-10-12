using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Admin.Controllers
{
    public class CareerController : BaseAdminController
    {
        private readonly IApiService _apiService;

        public CareerController(IApiService apiService)
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
