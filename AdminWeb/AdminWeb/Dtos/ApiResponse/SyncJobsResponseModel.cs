namespace AdminWeb.Dtos.ApiResponse
{
    public class SyncJobsResponseModel
    {
        public long JobId { get; set; }
        public long ScheduleTypeId { get; set; }
        public string? ScheduleDescription { get; set; }
        public string? Description { get; set; }
        public DateTime? LastRun { get; set; }
        public DateTime? NextRun { get; set; }
        public bool? Enable { get; set; } = true;
        public bool? Valid { get; set; } = true;
        public bool? JobIsRunning { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
        public long? ComplexPriority { get; set; }
        public bool? ForceRun { get; set; } = false;
    }
}
