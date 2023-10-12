namespace AdminWeb.Dtos.ApiResponse
{
    public class ClaimStatusResponseModel
    {
        public long ClaimStatusId { get; set; }
        public string ClaimStatusName { get; set; }
        public string ClaimStatusNameVN { get; set; }

        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
