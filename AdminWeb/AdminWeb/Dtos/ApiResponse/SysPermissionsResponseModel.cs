namespace AdminWeb.Dtos.ApiResponse
{
    public class SysPermissionsResponseModel
    {
        public long PermissionId { get; set; }

        public string PermissionName { get; set; }

        public string Description { get; set; }

        public long? Type { get; set; }

        public string Application { get; set; }

        public long? ParentId { get; set; }
        public string ParentName { get; set; }

        public bool? IsPermisstion { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? CreationDate { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? LastUpdatedDate { get; set; }

        public long? LastUpdatedBy { get; set; }
    }
}
