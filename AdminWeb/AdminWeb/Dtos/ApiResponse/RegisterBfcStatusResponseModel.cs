namespace AdminWeb.Dtos.ApiResponse
{
    public class RegisterBfcStatusResponseModel
    {
        public long RegisterBfcStatusId { get; set; }

        public string RegisterBfcStatusCode { get; set; }

        public string RegisterBfcStatusName { get; set; }

        public long PositionId { get; set; }

        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
