namespace AdminWeb.Dtos.ApiResponse
{
    public class LiablityStatusResponseModel
    {
        public long LiablityStatusId { get; set; }
        public string LiablityStatusName { get; set; }
        public string LiablityStatusNameVN { get; set; }
        
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
