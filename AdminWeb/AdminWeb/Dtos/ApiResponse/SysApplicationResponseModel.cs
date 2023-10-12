namespace AdminWeb.Dtos.ApiResponse
{
    public class SysApplicationResponseModel
    {
        public string SysApplicationId { get; set; }
        public string SysApplicationName { get; set; }
        public int? Index { get; set; }

        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
