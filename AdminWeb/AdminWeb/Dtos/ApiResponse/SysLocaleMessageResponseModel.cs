namespace AdminWeb.Dtos.ApiResponse
{
    public class SysLocaleMessageResponseModel
    {
        public long LocaleMessagesId { get; set; }
        public string MessageName { get; set; }
        public string MessageValue { get; set; }
        public int LanguageId { get; set; }
        public string LanguageName { get; set; }

        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
