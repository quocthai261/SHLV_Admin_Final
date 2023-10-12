namespace AdminWeb.Dtos.ApiResponse
{
    public class SysRoleModel
    {
        public long RoleId { get; set; }

        public string ConCurrencyStamp { get; set; }

        public string Name { get; set; }

        public string NormalizedName { get; set; }

        public string Code { get; set; }

        public bool? IsSystem { get; set; }

        public DateTime? CreationDate { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? LastUpdatedDate { get; set; }

        public long? LastUpdatedBy { get; set; }
    }
}
