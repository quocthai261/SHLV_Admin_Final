using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Models;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Admin.Controllers
{
    public class RolesController : BaseAdminController
    {
        private readonly IApiService _apiService;

        public RolesController(IApiService apiService)
        {
            _apiService = apiService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            else
            {
                

                return View();
            }
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpGet]
        public object GetRolesListApi(DataSourceLoadOptions loadOptions)
        {
            var _response = _apiService.GetRoleListApi().Result;

            return DataSourceLoader.Load(_response, loadOptions);
        }

    }
}
