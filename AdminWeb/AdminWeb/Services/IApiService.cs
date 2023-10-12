using AdminWeb.Dtos.ApiResponse;
using AdminWeb.Models;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AdminWeb.Services
{
    public interface IApiService
    {
        #region -- Admin --

        Task<List<SysUsersModel>> GetUserListApi();

        Task<List<SysRoleModel>> GetRoleListApi();

        Task<List<SysPermissionsResponseModel>> GetPermissionListApi();

        Task<List<SysSettingsResponseModel>> GetSettingListApi();

        Task<List<SysMenusResponseModel>> GetMenuListApi();

        #endregion

        #region UserMenu
        Task<UserDetailViewModel> GetEditUser(long id);
        Task SubmitEditUser(UserDetailViewModel model);
        #endregion UserMenu

    }
}

