namespace AdminWeb.Dtos.ApiResponse
{
    public class SysSettingsResponseModel
    {
        public long SettingId { get; set; }

        public string? GroupSetting { get; set; }

        public string? SettingCode { get; set; }

        public string? SettingName { get; set; }

        public string? SettingValue { get; set; }

        public string? SettingDesciption { get; set; }

        public bool IsActive { get; set; }

        public DateTime? CreationDate { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? LastUpdatedDate { get; set; }

        public long? LastUpdatedBy { get; set; }
    }
}
