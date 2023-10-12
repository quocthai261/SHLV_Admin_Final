namespace AdminWeb.Dtos.ApiResponse
{
    public class ClaimTypeResponseModel
    {
        public long ClaimTypeId { get; set; }
        public string Description { get; set; }
        public string ClaimTypeCode { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
        public long? IsActiveForClaim { get; set; }
        public long? IsRequireDoc { get; set; }
    }
}
