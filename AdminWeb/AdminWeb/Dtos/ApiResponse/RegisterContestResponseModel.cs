namespace AdminWeb.Dtos.ApiResponse
{
    public class RegisterContestResponseModel
    {
        public long RegisterContestId { get; set; } 

        public long UserId { get; set; }

        public string FCCode { get; set; }

        public string ContestId { get; set; }

        public DateTime RegisterDate { get; set; }

        public string Option { get; set; }

        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
