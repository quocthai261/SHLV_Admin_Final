namespace AdminWeb.Dtos.ApiResponse
{
    public class ProvinceResponseModel
    {
        public long ProvinceId { get; set; }
        public string ProvinceCode { get; set; } = null!;
        public string? ProvinceName { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
