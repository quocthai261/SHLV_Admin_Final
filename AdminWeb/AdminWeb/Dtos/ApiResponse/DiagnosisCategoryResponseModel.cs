namespace AdminWeb.Dtos.ApiResponse
{
    public class DiagnosisCategoryResponseModel
    {
        public int DiagnosisCategoryId { get; set; }
        public string? CategoryDescription { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
