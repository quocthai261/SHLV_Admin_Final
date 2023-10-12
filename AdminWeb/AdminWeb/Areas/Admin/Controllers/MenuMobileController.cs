using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Admin.Controllers
{
    public class MenuMobileController : BaseAdminController
    {
        private readonly IApiService _apiService;

        public MenuMobileController(IApiService apiService)
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
                name = "Trang chủ"
            },
            new OsModel
            {
                code = "2",
                name = "Cài đặt"
            },
        };

        //[HttpGet]
        //public object GetInstantListApi(DataSourceLoadOptions loadOptions)
        //{
        //    var _response = modelInstant;

        //    return DataSourceLoader.Load(_response, loadOptions);
        //}

        //public static List<OsModel> modelInstant = new List<OsModel>()
        //{
        //    new OsModel
        //    {
        //        code = "1",
        //        name = "1"
        //    },
        //    new OsModel
        //    {
        //        code = "2",
        //        name = "2"
        //    },
        //};

        public static List<SysMenuMobileResponseModel> model = new List<SysMenuMobileResponseModel>()
        {
            new SysMenuMobileResponseModel {
                        MobileMenuId = 1,
                        Code = "F001",
                        Name = "Trang chủ",
                        Order_ = 1,
                        Icon1 = "Function_Icon/FuncIcon_F001.svg",
                        Icon2 = "Function_Icon/FuncIcon_sF001.svg",

                        Color1 = "#36CBFA",
                        Color2 = "#36CBFA",
                        Color3 = "#36CBFA",

                        ParentId = "",
                        ParentName = "",

                        PermissionName = "HomeMobile.AllowView",

                        FavoriteIndex = 1,
                        IsFavoriteDefault = true,
                        IsDefault = true,
                        IsInstantPush = true,
                        SetInstantPush = true,
                        InstantPushId = 1,


                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new SysMenuMobileResponseModel {
                        MobileMenuId = 2,
                        Code = "F002",
                        Name = "Đăng ký FC",
                        Order_ = 2,
                        Icon1 = "Function_Icon/FuncIcon_F001.svg",
                        Icon2 = "Function_Icon/FuncIcon_sF001.svg",

                        Color1 = "#36CBFA",
                        Color2 = "#36CBFA",
                        Color3 = "#36CBFA",

                        ParentId = "1;",
                        ParentName = "Trang chủ",

                        PermissionName = "RegisterFCMobile.AllowView",

                        //FavoriteIndex = 1,
                        IsFavoriteDefault = false,
                        IsDefault = true,
                        IsInstantPush = false,
                        //SetInstantPush = 1,
                        //InstantPushId = 1,


                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },

        };
    }
}
