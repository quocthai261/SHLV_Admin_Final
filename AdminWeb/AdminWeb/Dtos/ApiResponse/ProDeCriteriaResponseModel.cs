namespace AdminWeb.Dtos.ApiResponse
{
    public class ProDeCriteriaResponseModel
    {
        public long ProDeCriteriaId { get; set; }
        public string? Title { get; set; }
        public string? Code { get; set; }
        public string? Unit { get; set; }
        public string? Icon { get; set; }
        public string? EndPoint { get; set; }
        public string? ProcessColor { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
