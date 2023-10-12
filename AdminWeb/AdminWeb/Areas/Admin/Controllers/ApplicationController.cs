using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Admin.Controllers
{
    public class ApplicationController : BaseAdminController
    {
        private readonly IApiService _apiService;

        public ApplicationController(IApiService apiService)
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

        public static List<SysApplicationResponseModel> model = new List<SysApplicationResponseModel>()
        {
            new SysApplicationResponseModel {
                        SysApplicationId = "22855d68-0419-4224-8e25-6d1f960d231f",
                        SysApplicationName = "Web",
                        Index = 1,

                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new SysApplicationResponseModel {
                        SysApplicationId = "0d111eef-12de-4338-b644-b554c8539605",
                        SysApplicationName = "Mobile",
                        Index = 2,

                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
        };
    }
}
