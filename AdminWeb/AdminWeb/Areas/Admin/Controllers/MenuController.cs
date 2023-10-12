using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Admin.Controllers
{
    public class MenuController : BaseAdminController
    {
        private readonly IApiService _apiService;

        public MenuController(IApiService apiService)
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

        [HttpGet]
        public object GetMenuListApi(DataSourceLoadOptions loadOptions)
        {
            var _response = modelMenu;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<OsModel> modelMenu = new List<OsModel>()
        {
            new OsModel
            {
                code = "1",
                name = "Quản lý job và đồng bộ"
            },
            new OsModel
            {
                code = "2",
                name = "Chức năng nhân viên nghiệp vụ (BU)"
            },
            new OsModel
            {
                code = "3",
                name = "Tiêu chí tích điểm"
            },
            new OsModel
            {
                code = "4",
                name = "Tra cứu/Đăng tải điểm người dùng"
            },
        };

        public static List<SysMenusResponseModel> model = new List<SysMenusResponseModel>()
        {
            new SysMenusResponseModel {
                        MenuId = 1,
                        AppId = 1,
                        Content = "Thiết lập tiêu chí theo vị trí ĐG",
                        IconClass = "fa fa-caret-right",
                        Url = "Category/MapCriteriasPosition/List",
                        Order = 1,
                        PermissionName = "MapCriteriasPosition.AllowView",
                        ParentId = null,
                        ParentName = "",
                        IsActive = true,
                        SystemName = "MapCriteriasPosition",
                        IsDefault = true,

                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new SysMenusResponseModel {
                        MenuId = 2,
                        AppId = 1,
                        Content = "Người dùng",
                        IconClass = "fa fa-caret-right",
                        Url = "Admin/Users/List",
                        Order = 1,
                        PermissionName = "MapCriteriasPosition.AllowView",
                        ParentId = 1,
                        ParentName = "Thiết lập tiêu chí theo vị trí ĐG",
                        IsActive = true,
                        SystemName = "User.AllowView",
                        IsDefault = true,

                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new SysMenusResponseModel {
                        MenuId = 3,
                        AppId = 1,
                        Content = "Nhóm người dùng",
                        IconClass = "fa fa-caret-right",
                        Url = "Admin/Roles/List",
                        Order = 1,
                        PermissionName = "Role.AllowView",
                        ParentId = null,
                        IsActive = true,
                        SystemName = "Role",
                        IsDefault = true,

                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
        };
    }
}
