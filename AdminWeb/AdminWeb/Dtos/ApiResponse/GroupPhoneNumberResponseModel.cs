namespace AdminWeb.Dtos.ApiResponse
{
    public class GroupPhoneNumberResponseModel
    {
        public long GroupPhoneNumberID { get; set; }
        public string PhoneNumber { get; set; }
        public int? GroupFunction { get; set; }

        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
