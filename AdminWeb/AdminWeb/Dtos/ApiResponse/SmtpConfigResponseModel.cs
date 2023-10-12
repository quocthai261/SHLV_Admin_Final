namespace AdminWeb.Dtos.ApiResponse
{
    public class SmtpConfigResponseModel
    {
        public long SmtpConfigId { get; set; }
        public string? NetworkCredentialUsername { get; set; }
        public string? NetworkCredentialPassword { get; set; }
        public string? FromAddress { get; set; }
        public string? FromDisplayName { get; set; }
        public bool? EnableSSL { get; set; }
        public long? UseDefaultCredentials { get; set; }
        public string? SmtpClientPort { get; set; }
        public string? SmtpClientHost { get; set; }
        public string? PasswordLength { get; set; }
        public long? PwIncludeSpecial { get; set; }
        public long? PwIncludeNumberic { get; set; }
        public long? PwIncludeUppercase { get; set; }
        public long? PwIncludeLowercase { get; set; }
        public long? DefaultGenPw { get; set; }
        public bool? Active { get; set; }
        public string? GroupCode { get; set; }
        public long? AllowMailRegister { get; set; }
        public long? AllowMailUserIdPass { get; set; }
        public long? AllowMailRegisterBod { get; set; }
        public long? AllowMailUserIdPassBod { get; set; }
        public string? RouterHosting { get; set; }
        public string? ListMailTo { get; set; }
        public string? ListMailBCC { get; set; }
        public string? ListMailCC { get; set; }
        public string? ObjectType { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
        public DateTime? EffectDate { get; set; }
        public string? Creator { get; set; }
    }
}
