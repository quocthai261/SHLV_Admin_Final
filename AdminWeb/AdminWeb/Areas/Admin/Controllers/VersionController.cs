using AdminWeb.Areas.BaseController;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Areas.Admin.Controllers
{
    public class VersionController : BaseAdminController
    {
        private readonly IApiService _apiService;

        public VersionController(IApiService apiService)
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
        public object GetOsListApi(DataSourceLoadOptions loadOptions)
        {
            var _response = modelOs;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        [HttpGet]
        public object GetEnvListApi(DataSourceLoadOptions loadOptions)
        {
            var _response = modelEnv;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<OsModel> modelEnv = new List<OsModel>()
        {
            new OsModel
            {
                code = "uat",
                name = "uat"
            },
            new OsModel
            {
                code = "Prod",
                name = "Prod"
            },
        };

        public static List<OsModel> modelOs = new List<OsModel>()
        {
            new OsModel
            {
                code = "iOS",
                name = "iOS"
            },
            new OsModel
            {
                code = "Android",
                name = "Android"
            },
        };

        public static List<SysVersionResponseModel> model = new List<SysVersionResponseModel>()
        {
            new SysVersionResponseModel {
                        VersionId = 1,
                        ApplicationCode = "mSFA",
                        ApplicationName = "SFA - Mobile",
                        Version = "0.1.3",
                        ForceUpdate = true,
                        Os = "Android",
                        Env = "uat",
                        AppsStoreUrl = "https://install.appcenter.ms/orgs/fis.mobile/apps/lime-pro-uat-ios/distribution_groups/public",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new SysVersionResponseModel {
                        VersionId = 2,
                        ApplicationCode = "mSFA",
                        ApplicationName = "SFA - Mobile",
                        Version = "0.1.3",
                        ForceUpdate = false,
                        Os = "iOS",
                        Env = "uat",
                        AppsStoreUrl = "https://install.appcenter.ms/orgs/fis.mobile/apps/lime-pro-uat-ios/distribution_groups/public",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new SysVersionResponseModel {
                        VersionId = 3,
                        ApplicationCode = "mSFA",
                        ApplicationName = "SFA - Mobile",
                        Version = "0.1.3",
                        ForceUpdate = true,
                        Os = "Android",
                        Env = "uat",
                        AppsStoreUrl = "https://install.appcenter.ms/orgs/fis.mobile/apps/lime-pro-uat-ios/distribution_groups/public",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new SysVersionResponseModel {
                        VersionId = 4,
                        ApplicationCode = "mSFA",
                        ApplicationName = "SFA - Mobile",
                        Version = "0.1.3",
                        ForceUpdate = true,
                        Os = "iOS",
                        Env = "uat",
                        AppsStoreUrl = "https://install.appcenter.ms/orgs/fis.mobile/apps/lime-pro-uat-ios/distribution_groups/public",
                        IsActive = true,
                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
        };
    }
}
