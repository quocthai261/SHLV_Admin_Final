namespace AdminWeb.Dtos.ApiResponse
{
    public class SysUserLoginHistoryResponseModel
    {
        public long UserLoginHistoryId { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public DateTime? LoginDate { get; set; }
        public string Browser { get; set; }
        public string Device { get; set; }
        public string IpAddress { get; set; }
        public int? Status { get; set; }


        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
