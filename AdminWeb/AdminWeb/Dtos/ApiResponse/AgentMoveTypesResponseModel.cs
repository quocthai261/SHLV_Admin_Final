namespace AdminWeb.Dtos.ApiResponse
{
    public class AgentMoveTypesResponseModel
    {
        public long AgentMoveTypeId { get; set; }
        public string? TypeCode { get; set; }
        public string? TypeName { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
