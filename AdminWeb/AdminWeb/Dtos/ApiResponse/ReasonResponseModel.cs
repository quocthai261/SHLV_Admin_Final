namespace AdminWeb.Dtos.ApiResponse
{
    public class ReasonResponseModel
    {
        public long ReasonId { get; set; }

        public long ReasonType { get; set; }    

        public string ReasonName { get; set; }

        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
