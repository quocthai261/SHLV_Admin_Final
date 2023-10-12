namespace AdminWeb.Dtos.ApiResponse
{
    public class PositionResponseModel
    {
        public long PositionId { get; set; }

        public string PositionCode { get; set; }

        public string PositionName { get; set; }

        public bool IsRegister { get; set; }

        public bool IsApproval { get; set; }    

        public string Description { get; set; }

        public string Image { get; set; }

        public string NextPosition { get; set; }

        public string NextPositionDescription { get; set; }

        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
