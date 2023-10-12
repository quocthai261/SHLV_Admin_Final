namespace AdminWeb.Dtos.ApiResponse
{
    public class DistrictResponseModel
    {
        public long DistrictId { get; set; }
        public long? ProvinceId { get; set; }
        public string ProvinceName { get; set; }
        public string DistrictCode { get; set; }
        public string DistrictName { get; set; }

        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
