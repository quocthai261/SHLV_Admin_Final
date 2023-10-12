using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Models;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace AdminWeb.Areas.Admin.Controllers
{
    public class UsersController : BaseAdminController
    {
        public const string SubmitEditEndpoint = "submit-edit";

        private readonly IApiService _apiService;

        public UsersController(IApiService apiService)
        {
            _apiService = apiService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Edit(long id)
        {
            if(id == 0)
            {
                return NotFound();
            }
            else
            {
                SysUsersModel user = SampleData.users.FirstOrDefault(x => x.UserId == id);
                UserDetailViewModel detail = new UserDetailViewModel()
                {
                    User = user,
                    RoleIDs = new long[] { 11 },
                    PermissionIds = new long[] { 2, 4 }
                };
                return View(detail);
                //var response = await _apiService.GetEditUser(id);

                //return View(response);
            }           
        }

        [Route(SubmitEditEndpoint)]
        [HttpPost]
        public async Task<JsonResult> SubmitEdit([FromBody] UserDetailViewModel model)
        {
            //await _apiService.SubmitEditUser(model);
            //return RedirectToAction("Index");
            return Json("Success");
        }

        #region -- methods --

        [HttpGet]
        public object GetUsersListApi(DataSourceLoadOptions loadOptions)
        {
            var _response = _apiService.GetUserListApi().Result;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        #endregion
    }
}
