using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Admin.Controllers
{
    public class UserLoginHistoryController : BaseAdminController
    {
        private readonly IApiService _apiService;

        public UserLoginHistoryController(IApiService apiService)
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

        public static List<SysUserLoginHistoryResponseModel> model = new List<SysUserLoginHistoryResponseModel>()
        {
            new SysUserLoginHistoryResponseModel {
                        UserLoginHistoryId = 1,
                        UserName = "0904234432",
                        FullName = "Nguyen Van A",
                        Browser = "Google chrome",
                        Device = "Win 11",
                        IpAddress = "192.168.1.1",
                        Status = 1,
                        LoginDate = DateTime.Now,

                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new SysUserLoginHistoryResponseModel {
                        UserLoginHistoryId = 1,
                        UserName = "admin",
                        FullName = "admin",
                        Browser = "Google chrome",
                        Device = "Iphone 11",
                        IpAddress = "192.168.1.1",
                        Status = 1,
                        LoginDate = DateTime.Now,

                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new SysUserLoginHistoryResponseModel {
                        UserLoginHistoryId = 1,
                        UserName = "0904234432",
                        FullName = "Nguyen Van B",
                        Browser = "Google chrome",
                        Device = "Win 11",
                        IpAddress = "192.168.1.1",
                        Status = 1,
                        LoginDate = DateTime.Now,

                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    }
        };
    }
}
