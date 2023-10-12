namespace AdminWeb.Dtos.ApiResponse
{
    public class SysActivityLogResponseModel
    {
        public long ActivityLogId { get; set; }
        public string UserName { get; set; }
        public string Service { get; set; }
        public string IpAddress { get; set; }
        public string Client { get; set; }
        public string Host { get; set; }
        public DateTime Time { get; set; }
        public string CustomData { get; set; }
        public int? State { get; set; }
        public string Action { get; set; }
        public string Duration { get; set; }
        public string Source { get; set; }
        public string Device { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }

        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
