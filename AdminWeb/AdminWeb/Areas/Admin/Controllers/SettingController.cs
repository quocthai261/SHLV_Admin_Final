using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Admin.Controllers
{
    public class SettingController : BaseAdminController
    {
        private readonly IApiService _apiService;

        public SettingController(IApiService apiService)
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

        public static List<SysSettingResponseModel> model = new List<SysSettingResponseModel>()
        {
            new SysSettingResponseModel {
                        SettingId = 1,
                        GroupSetting = "PasswordPolicySettings",
                        SettingCode = "RequiredLength",
                        SettingName = "Required Length",
                        SettingValue = "8",
                        SettingDesciption = "The minimum length of the password.",

                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new SysSettingResponseModel {
                        SettingId = 1,
                        GroupSetting = "PasswordPolicySettings",
                        SettingCode = "RequireUppercase",
                        SettingName = "Require Uppercase",
                        SettingValue = "false",
                        SettingDesciption = "Requires an uppercase character in the password.",

                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new SysSettingResponseModel {
                        SettingId = 1,
                        GroupSetting = "PasswordPolicySettings",
                        SettingCode = "RequireLowercase",
                        SettingName = "Require Lowercase",
                        SettingValue = "13",
                        SettingDesciption = "Requires a lowercase character in the password.",

                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
        };
    }
}
