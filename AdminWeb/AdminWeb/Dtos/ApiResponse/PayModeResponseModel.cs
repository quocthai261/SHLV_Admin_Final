namespace AdminWeb.Dtos.ApiResponse
{
    public class PayModeResponseModel
    {
        public long PayModeId { get; set; }
        public string PayModeName { get; set; }
        public string? PayModeType { get; set; }
        public string? PayModeNameVN { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
