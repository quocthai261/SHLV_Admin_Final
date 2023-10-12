namespace AdminWeb.Dtos.ApiResponse
{
    public class SysUsersModel
    {
        public long UserId { get; set; }

        public string ReferentId { get; set; }

        public string UserName { get; set; }

        public long UserType { get; set; }

        public int? UserRule { get; set; }

        public string Provider { get; set; }

        public string Name { get; set; }

        public string SurName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime? LastLogin { get; set; }

        public DateTime? CreationDate { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? LastUpdatedDate { get; set; }

        public long? LastUpdatedBy { get; set; }
    }
}
