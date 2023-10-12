namespace AdminWeb.Dtos.ApiResponse
{
    public class NationalitiesResponseModel
    {
        public long NationalityId { get; set; }
        public string? NationalityCode { get; set; }
        public string? NationalityName { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
