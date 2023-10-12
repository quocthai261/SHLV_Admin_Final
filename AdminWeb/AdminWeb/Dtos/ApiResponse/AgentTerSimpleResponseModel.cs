namespace AdminWeb.Dtos.ApiResponse
{
    public class AgentTerSimpleResponseModel
    {
        public long AgentTerSimpleId { get; set; }
        public string? RequestCode { get; set; }
        public string? RequestName { get; set; }
        public DateTime? RequestDate { get; set; }
        public string? AgentCode { get; set; }
        public string? Reason { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string? LastUpDatedBy { get; set; }
        public string? Position { get; set; }
        public long? Status { get; set; }
        public string? StatusName { get; set; }
        public string? RejectReason { get; set; }
        public string? PositionName { get; set; }
        public string? AgentName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string? UnitDeptCode { get; set; }
        public string? UnitName { get; set; }
        public string? UnitLeader { get; set; }
        public string? UnitLeaderName { get; set; }
        public string? DistrictDeptCode { get; set; }
        public string? DistrictName { get; set; }
        public string? DistrictNeader { get; set; }
        public string? DistrictLeaderName { get; set; }
        public string? RegionDeptCode { get; set; }
        public string? RegionName { get; set; }
        public string? RegionLeader { get; set; }
        public string? RegionLeaderName { get; set; }
        public string? PositionApply { get; set; }
        public string? RequestTypes { get; set; }
    }
}
