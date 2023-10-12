namespace AdminWeb.Common.Provider
{
    public class UrlApiProvider
    {
        #region -- Admin --

        public const string getAllRole = "/Roles/get-all";

        public const string getAllPermission = "/Permissions/get-all";

        public const string getAllSetting = "/Settings/get-all";

        public const string getAllMenus = "/Menu/get-all";

        #endregion
    }

    public class UrlUserApiProvider
    {
        public const string GetAllUsers = "/Users/get-all-user";
        public const string EditUsers = "/Users/{userId}";
        public const string SubmitEditUsers = "/Users/update-user";
    }
}
