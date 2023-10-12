namespace AdminWeb.Dtos.ApiResponse
{
    public class PolicyStatusResponseModel
    {
        public long PolicyStatusId { get; set; }
        public string? PolicyStatusCode { get; set; }
        public string? PolicyStatusName { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
