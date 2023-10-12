namespace AdminWeb.Dtos.ApiResponse
{
    public class ApprovalConfigurationDetailResponseModel
    {
        public long ApprovalConfigurationDetailId { get; set; }
        public long? ApprovalConfigurationId { get; set; }
        public string? Position { get; set; }
        public int? ProcessStep { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
        public long? Type { get; set; }

    }
}
