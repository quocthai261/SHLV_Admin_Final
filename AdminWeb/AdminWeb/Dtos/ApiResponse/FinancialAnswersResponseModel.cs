namespace AdminWeb.Dtos.ApiResponse
{
    public class FinancialAnswersResponseModel
    {
        public long FinAnswerId { get; set; }
        public string? QuestionCode { get; set; }
        public string? AnswerCode { get; set; }
        public long? Index { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
        public long? AnswerType { get; set; }
        public string? AnswerName { get; set; }
    }
}
