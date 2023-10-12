namespace AdminWeb.Dtos.ApiResponse
{
    public class AnswersResponseModel
    {
        public long AnswerId { get; set; }

        public long CriteriaId { get; set; }    

        public string AnswerContent { get; set; }   

        public long Index { get; set; }

        public string AnswerCode { get; set; }

        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
