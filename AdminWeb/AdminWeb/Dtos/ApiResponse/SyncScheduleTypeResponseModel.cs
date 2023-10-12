namespace AdminWeb.Dtos.ApiResponse
{
    public class SyncScheduleTypeResponseModel
    {
        public long ScheduleTypeId { get; set; }
        public string? Description { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
