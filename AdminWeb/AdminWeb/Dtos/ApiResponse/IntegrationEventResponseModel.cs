namespace AdminWeb.Dtos.ApiResponse
{
    public class IntegrationEventResponseModel
    {
        public long EventId { get; set; }
        public string Content { get; set; }
        public int? State { get; set; }
        public int? SentTime { get; set; }
        public string EventTypeName { get; set; }
        public string TransactionId { get; set; }

        public DateTime? CreationDate { get; set; }
    }
}
