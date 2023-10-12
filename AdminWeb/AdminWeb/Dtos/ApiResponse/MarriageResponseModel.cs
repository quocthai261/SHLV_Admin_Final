namespace AdminWeb.Dtos.ApiResponse
{
    public class MarriageResponseModel
    {
        public int MarriageId { get; set; }

        public string MarriageName { get; set; }

        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
