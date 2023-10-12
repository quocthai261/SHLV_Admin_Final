namespace AdminWeb.Dtos.ApiResponse
{
    public class SalePlanConfigResponseModel
    {
        public long SalePlanConfigId { get; set; }
        public string? PositionCode { get; set; }
        public long? AllowCreateDay { get; set; }
        public long? AllowEditDay { get; set; }
        public int? PlanType { get; set; }
        //public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
    //PDK- (29.9.2023)
    //Do không có bảng PlanType dưới DB để show giao diện
    //Không thể show số (PlanType Property)
    //Tạm thời thêm PlanTypeFake để tiện fake data, nếu có PlanType thì hãy xóa property này đi
    public class PlanTypeFake
    {
        public int PlanTypeId { get; set; }
        public string? PlanName { get; set; }
    }
}
