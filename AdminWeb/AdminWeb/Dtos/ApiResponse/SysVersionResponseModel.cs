namespace AdminWeb.Dtos.ApiResponse
{
    public class SysVersionResponseModel
    {
        public long VersionId { get; set; }
        public string ApplicationCode { get; set; }
        public string ApplicationName { get; set; }
        public string Version { get; set; }
        public bool? ForceUpdate { get; set; }
        public string Os { get; set; }
        public string Env { get; set; }
        public string AppsStoreUrl { get; set; }


        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }


    public class OsModel
    {
        public string name { get; set; }
        public string code { get; set; }
    }
}
