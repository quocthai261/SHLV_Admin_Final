namespace AdminWeb.Dtos.ApiResponse
{
    public class NotificationResponseModel
    {
        public long NotificationId { get; set; }
        public string Code { get; set; }
        public string FunctionName { get; set; }
        public bool IsDefault { get; set; }
        public bool IsOTPType { get; set; }
        public bool IsNotifyType { get; set; }
        public bool IsLogin { get; set; }
        public bool IsPFC { get; set; }
        public bool IsBU { get; set; }
        public bool IsFC { get; set; }

        public bool IsGAD { get; set; }

        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
    }
}
