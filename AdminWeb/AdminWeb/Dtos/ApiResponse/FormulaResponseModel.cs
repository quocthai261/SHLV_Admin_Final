namespace AdminWeb.Dtos.ApiResponse
{
    public class FormulaResponseModel
    {
        public long FormulaId { get; set; }
        public string? ValueOne { get; set; }
        public string? ValueTwo { get; set; }
        public string? Description { get; set; }
        public int? Type { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
