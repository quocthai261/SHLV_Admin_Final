namespace AdminWeb.Dtos.ApiResponse
{
    public class BankOrgResponseModel
    {
        public long BankOrgId { get; set; }
        public string BankOrgName { get; set; }
        public string BankOrgCode { get; set; }
        public string BankName { get; set; }
        public long? IdType { get; set; }
        public string? IdNumber { get; set; }
        public string? AbbrName { get; set; }
        public string? Status { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
