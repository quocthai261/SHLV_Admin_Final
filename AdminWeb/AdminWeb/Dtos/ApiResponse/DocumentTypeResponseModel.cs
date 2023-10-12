namespace AdminWeb.Dtos.ApiResponse
{
    public class DocumentTypeResponseModel
    {
        public long DocumentTypeId { get; set; }
        public string DocumentTypeName { get; set; }
        public bool? IsExternal { get; set; }

        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
