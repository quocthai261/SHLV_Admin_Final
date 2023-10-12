namespace AdminWeb.Dtos.ApiResponse
{
    public class CertiTypeResponseModel
    {
        public long CertiTypeId { get; set; }
        public string CertiTypeName { get; set; }
        public string CertiTypeNameVN { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
