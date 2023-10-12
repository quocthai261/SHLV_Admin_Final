namespace AdminWeb.Dtos.ApiResponse
{
    public class PositionApplingsResponseModel
    {
        public long PositionApplingsId { get; set; }
        public string? PositionApplingCode { get; set; }
        public string? PositionApplingName { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
        public string? Image { get; set; }
    }
}
