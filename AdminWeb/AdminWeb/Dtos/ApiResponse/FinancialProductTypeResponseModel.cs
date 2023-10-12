namespace AdminWeb.Dtos.ApiResponse
{
    public class FinancialProductTypeResponseModel
    {
        public long FinProductTypeId { get; set; }
        public string? ProductTypeCode { get; set; }
        public string? Image { get; set; }
        public string? ProductTypeName { get; set; }
        public string? Description { get; set; }
        public string? UrlProduct { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
        public List<FinancialProductTypeSubResponseModel> lstChild { get; set; }
    }
}
