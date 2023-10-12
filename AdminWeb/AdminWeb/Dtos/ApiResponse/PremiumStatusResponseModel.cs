namespace AdminWeb.Dtos.ApiResponse
{
    public class PremiumStatusResponseModel
    {
        public long PremiumStatusId { get; set; }
        public string PremiumStatusName { get; set; }
        public string PremiumStatusNameVN { get; set; }

        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
