namespace AdminWeb.Dtos.ApiResponse
{
    public class ApprovalConfigurationResponseModel
    {
        public long ApprovalConfigurationId { get; set; }
        public string? TypeCode { get; set; }
        public string? PositionCode { get; set; }
        public string? Description { get; set; }
        public DateTime? ApplyDate { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
