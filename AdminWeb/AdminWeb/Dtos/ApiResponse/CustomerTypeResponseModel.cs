namespace AdminWeb.Dtos.ApiResponse
{
    public class CustomerTypeResponseModel
    {
        public long CustomerTypeId { get; set; }
        public string? CustomerTypeCode { get; set; }
        public string? CustomerTypeName { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
