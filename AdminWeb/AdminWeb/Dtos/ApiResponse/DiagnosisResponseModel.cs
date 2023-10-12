namespace AdminWeb.Dtos.ApiResponse
{
    public class DiagnosisResponseModel
    {
        public long DiagnosisId { get; set; }
        public string? DiagnoDescription { get; set; }
        public long? ParentId { get; set; }
        public int DiagnoCategory { get; set; }
        public string DiagnoName { get; set; } = null!;
        public string? Acceptable { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
