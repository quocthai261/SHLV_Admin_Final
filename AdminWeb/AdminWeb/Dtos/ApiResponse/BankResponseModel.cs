namespace AdminWeb.Dtos.ApiResponse
{
    public class BankResponseModel
    {
        public long BankId { get; set; }
        public string? BankCode { get; set; }
        public string? BankName { get; set; }
        public string? BankIcon { get; set; }
        public string? Color1 { get; set; }
        public string? Color2 { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
