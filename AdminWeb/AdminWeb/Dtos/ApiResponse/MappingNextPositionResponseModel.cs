namespace AdminWeb.Dtos.ApiResponse
{
    public class MappingNextPositionResponseModel
    {
        public long MappingId { get; set; }
        public string CurrentPositionCode    { get; set; }
        public string NextPositionCode { get; set; }

        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
