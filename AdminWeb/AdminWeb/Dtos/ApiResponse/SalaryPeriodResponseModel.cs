namespace AdminWeb.Dtos.ApiResponse
{
    public class SalaryPeriodResponseModel
    {
        public long SalaryPeriodId { get; set; }
        public string? SalaryPeriodCode { get; set; }
        public string? SalaryPeriodType { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
