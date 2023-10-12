namespace AdminWeb.Dtos.ApiResponse
{
    public class ConfigProDemotionResponseModel
    {
        public long ConfigProDemotionID { get; set; }
        public string? ConfigProDemotionCode { get; set; }
        public DateTime? ApplyDate { get; set; }
        public int? ConfigType { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedDateBy { get; set; }
        public int? PeriodReview { get; set; }
    }
}
