namespace AdminWeb.Dtos.ApiResponse
{
    public class SyncScheduleResponseModel
    {
        public long ScheduleId { get; set; }
        public long? JobId { get; set; }
        public bool? Monday { get; set; }
        public bool? Tuesday { get; set; }
        public bool? Wednesday { get; set; }
        public bool? Thursday { get; set; }
        public bool? Friday { get; set; }
        public bool? Saturday { get; set; }
        public bool? Sunday { get; set; }
        public DateTime? OccursAt { get; set; }
        public long? Interval { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }

    public class ScheduleModel
    {
        public int ID { get; set; }
        public string? Text { get; set; }
    }
}
