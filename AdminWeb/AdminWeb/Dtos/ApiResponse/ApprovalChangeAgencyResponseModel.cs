namespace AdminWeb.Dtos.ApiResponse
{
    public class ApprovalChangeAgencyResponseModel
    {
        public ApprovalChangeAgencyResponseModel()
        {
            lstUserApprove = new List<ListUserApprove>();
        }

        public long ApprovalChangeAgencyId { get; set; }
        public int RequestType { get; set; }
        public string RequestTypeName { get; set; }
        public string RequestCode { get; set; }
        public string Name { get; set; }

        public string FCCode { get; set; }
        public string RequestName { get; set; }

        public string Reason { get; set; }
        public string StepRequest { get; set; }
        public string RequestNameNext { get; set; }

        public int Status { get; set; }
        public string StatusName { get; set; }

        public string ReasonReject { get; set; }

        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public List<ListUserApprove> lstUserApprove { get; set; }
    }

    public class ListUserApprove
    {
        public long UserId { get; set; }
        public string UserName { get; set; }
        public string UserCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Position { get; set; }
        public DateTime? ApproveDate { get; set; }
    }
}
