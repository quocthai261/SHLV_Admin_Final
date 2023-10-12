namespace AdminWeb.Dtos.ApiResponse
{
    public class GenderResponseModel
    {
        public long GenderId { get; set; }
        public string GenderCode { get; set; }
        public string GenderDescription { get; set; }
        public string GenderDescriptionVN { get; set; }

        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
