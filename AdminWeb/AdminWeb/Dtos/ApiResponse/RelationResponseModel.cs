namespace AdminWeb.Dtos.ApiResponse
{
    public class RelationResponseModel
    {
        public long RelationId { get; set; }
        public string? RelationCode { get; set; }
        public string? RelationName { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
