namespace AdminWeb.Dtos.ApiResponse
{
    public class WardResponseModel
    {
        public long WardId { get; set; }
        public long DistrictId { get; set; }
        public string WardCode { get; set; }
        public string WardName { get; set; }
        //public string WardCode { get; set; }
        public string SalaryPeriodType { get; set; }

        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
