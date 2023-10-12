namespace AdminWeb.Dtos.ApiResponse
{
    public class FinancialQuestionResponseModel
    {
        public long FinQuestionId { get; set; }
        public string? ProductTypeCode { get; set; }
        public string? QuestionCode { get; set; }
        public string? QuestionName { get; set; }
        public int? QuestionType { get; set; }
        public int? Step { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
