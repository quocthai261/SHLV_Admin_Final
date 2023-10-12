namespace AdminWeb.Dtos.ApiResponse
{
    public class IncomeResponseModel
    {
        public long IncomeId { get; set; }
        public string IncomeCode { get; set; }
        public string IncomeName { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
    }
}
