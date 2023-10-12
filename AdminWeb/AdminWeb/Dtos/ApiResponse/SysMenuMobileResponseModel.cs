namespace AdminWeb.Dtos.ApiResponse
{
    public class SysMenuMobileResponseModel
    {
        public long MobileMenuId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsDefault { get; set; }
        public int? Order_ { get; set; }
        public string Icon1 { get; set; }
        public string Icon2 { get; set; }
        public string Color1 { get; set; }
        public string Color2 { get; set; }
        public string Color3 { get; set; }
        public string ParentId { get; set; }
        public string ParentName { get; set; }
        public string PermissionName { get; set; }
        public bool? IsFavoriteDefault { get; set; }
        public int? FavoriteIndex { get; set; }
        public bool? IsInstantPush { get; set; }
        public bool? SetInstantPush { get; set; }
        public long? InstantPushId { get; set; }



        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
