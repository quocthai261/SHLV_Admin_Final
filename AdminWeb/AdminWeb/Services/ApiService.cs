using AdminWeb.Services;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using DevExtreme.AspNet.Mvc;
using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Dtos.Configuration;
using Microsoft.Extensions.Options;
using AdminWeb.Common.Enums;
using AdminWeb.Common.Provider;
using AdminWeb.Common.Utilities;
using AdminWeb.Models;

namespace AdminWeb.Services
{
    public class ApiService : IApiService
    {
        private readonly ApiConfig _apiConfig;
        private readonly IHttpClientService _httpClient;

        public ApiService(IOptionsMonitor<ApiConfig> optionsMonitor, IHttpClientService httpClient)
        {
            _apiConfig = optionsMonitor.CurrentValue;
            _httpClient = httpClient;
        }

        #region -- Admin --

        public async Task<List<SysUsersModel>> GetUserListApi()
        {
            List<SysUsersModel> response = null;
            int result = (int)ResponseCode.Error;
            var uriCore = String.Concat(_apiConfig.BaseAddress, UrlUserApiProvider.GetAllUsers);

            (response, result) = await _httpClient.Get<List<SysUsersModel>>(uriCore);

            return await Task.FromResult(response);
        }

        public async Task<List<SysRoleModel>> GetRoleListApi()
        {
            List<SysRoleModel> response = null;
            int result = (int)ResponseCode.Error;
            var uriCore = String.Concat(_apiConfig.BaseAddress, UrlApiProvider.getAllRole);

            (response, result) = await _httpClient.Get<List<SysRoleModel>>(uriCore);

            return await Task.FromResult(response);
        }

        public async Task<List<SysPermissionsResponseModel>> GetPermissionListApi()
        {
            List<SysPermissionsResponseModel> response = null;
            int result = (int)ResponseCode.Error;
            var uriCore = String.Concat(_apiConfig.BaseAddress, UrlApiProvider.getAllPermission);

            (response, result) = await _httpClient.Get<List<SysPermissionsResponseModel>>(uriCore);

            return await Task.FromResult(response);
        }

        public async Task<List<SysSettingsResponseModel>> GetSettingListApi()
        {
            List<SysSettingsResponseModel> response = null;
            int result = (int)ResponseCode.Error;
            var uriCore = String.Concat(_apiConfig.BaseAddress, UrlApiProvider.getAllSetting);

            (response, result) = await _httpClient.Get<List<SysSettingsResponseModel>>(uriCore);

            return await Task.FromResult(response);
        }

        public async Task<List<SysMenusResponseModel>> GetMenuListApi()
        {
            List<SysMenusResponseModel> response = null;
            int result = (int)ResponseCode.Error;
            var uriCore = String.Concat(_apiConfig.BaseAddress, UrlApiProvider.getAllMenus);

            (response, result) = await _httpClient.Get<List<SysMenusResponseModel>>(uriCore);

            return await Task.FromResult(response);
        }

        public async Task<UserDetailViewModel> GetEditUser(long id)
        {
            UserDetailViewModel response = new UserDetailViewModel();
            int result = (int)ResponseCode.Error;
            var uriCore = String.Concat(_apiConfig.BaseAddress, UrlUserApiProvider.EditUsers.Replace("{userId}", id + ""));

            (response, result) = await _httpClient.Get<UserDetailViewModel>(uriCore);

            return await Task.FromResult(response);
        }

        public async Task SubmitEditUser(UserDetailViewModel model)
        {
            var requestModel = new UpdateUserRequestModel
            {
                UserId = model.User.UserId,
                Email = model.User.Email,
                PhoneNumber = model.User.PhoneNumber,
                roleIds = model.RoleIDs,
                permissionIds = model.PermissionIds
            };
            //int result = (int)ResponseCode.Error;
            var uriCore = String.Concat(_apiConfig.BaseAddress, UrlUserApiProvider.SubmitEditUsers);

            await _httpClient.PostJson<UserDetailViewModel>(uriCore, JsonConvert.SerializeObject(requestModel));

            //return Task.CompletedTask;
        }

        #endregion
    }
}

