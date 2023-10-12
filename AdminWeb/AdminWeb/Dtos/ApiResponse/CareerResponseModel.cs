namespace AdminWeb.Dtos.ApiResponse
{
    public class CareerResponseModel
    {
        public long CareerId { get; set; }
        public string CareerCode { get; set; }
        public string CareerName { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
    }
}
