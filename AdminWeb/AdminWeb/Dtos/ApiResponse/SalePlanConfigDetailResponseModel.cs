namespace AdminWeb.Dtos.ApiResponse
{
    public class SalePlanConfigDetailResponseModel
    {
        public long SalePlanConfigDetailId { get; set; }
        public long? SalePlanConfigId { get; set; }
        public string? ChiTieuKHKD { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
