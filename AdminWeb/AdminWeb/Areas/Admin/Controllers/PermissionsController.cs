using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Admin.Controllers
{
    public class PermissionsController : BaseAdminController
    {
        private readonly IApiService _apiService;

        public PermissionsController(IApiService apiService)
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

        [HttpPost]
        //[HlvValidateAntiForgeryToken]
        public async Task<ActionResult> Insert(string values)
        {
            try
            {
                

                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public async Task<ActionResult> Update(int key, string values)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int key)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public object GetDataTableList(DataSourceLoadOptions loadOptions)
        {
            //var _response = _apiService.GetPermissionListApi().Result;

            //return DataSourceLoader.Load(_response, loadOptions);
            var _response = model;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        [HttpGet]
        public object GetPermissionListApi(DataSourceLoadOptions loadOptions)
        {
            var _response = modelPermission;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<OsModel> modelPermission = new List<OsModel>()
        {
            new OsModel
            {
                code = "Notifications",
                name = "Notifications"
            },
            new OsModel
            {
                code = "Banks",
                name = "Banks"
            },
        };

        public static List<SysPermissionsResponseModel> model = new List<SysPermissionsResponseModel>()
        {
            new SysPermissionsResponseModel {
                        PermissionId = 1,
                        PermissionName = "Permission.AllowView",
                        Description = "Xem danh mục phân quyền quyền",
                        Application = "22855d68-0419-4224-8e25-6d1f960d231f",
                        ParentName = "ChargeMode",
                        IsPermisstion = true,

                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new SysPermissionsResponseModel {
                        PermissionId = 2,
                        PermissionName = "Message",
                        Description = "Quản lý thông báo",
                        Application = "22855d68-0419-4224-8e25-6d1f960d231f",
                        ParentName = "",
                        IsPermisstion = false,

                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
        };
    }
}
