using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Admin.Controllers
{
    public class ActivityLogController : BaseAdminController
    {
        private readonly IApiService _apiService;

        public ActivityLogController(IApiService apiService)
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

        public static List<SysActivityLogResponseModel> model = new List<SysActivityLogResponseModel>()
        {
            new SysActivityLogResponseModel {
                        ActivityLogId = 1,
                        Action = "mLogin",
                        Brand = "",
                        Client = "PostmanRuntime/7.28.4",
                        CustomData = "Xác thực thành công!",
                        Device = "phone",
                        Host = "",
                        Model = "15.2",
                        IpAddress = "192.168.1.1",
                        Service = "SYS_HLV_USERS",
                        State = 0,
                        UserName = "91300243",
                        Time = DateTime.Now,

                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new SysActivityLogResponseModel {
                        ActivityLogId = 2,
                        Action = "mLogin",
                        Brand = "",
                        Client = "iPhone11,2.ios.15.2",
                        CustomData = "Tên tài khoản hoặc mật khẩu không đúng.",
                        Device = "sdk_gphone_x86",
                        Host = "",
                        Model = "R",
                        IpAddress = "192.168.1.1",
                        Service = "SYS_HLV_USERS",
                        State = 0,
                        UserName = "91300243",
                        Time = DateTime.Now,

                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new SysActivityLogResponseModel {
                        ActivityLogId = 3,
                        Action = "mGetWelcome",
                        Brand = "",
                        Client = "iPhone11,2.ios.15.2",
                        CustomData = "Xác thực thất bại!",
                        Device = "iPhone11,2",
                        Host = "",
                        Model = "10",
                        IpAddress = "192.168.1.1",
                        Service = "SYS_HLV_USERS",
                        State = 0,
                        UserName = "91810988",
                        Time = DateTime.Now,

                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
        };
    }
}
