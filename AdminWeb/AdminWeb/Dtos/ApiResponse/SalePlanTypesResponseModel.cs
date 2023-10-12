namespace AdminWeb.Dtos.ApiResponse
{
    public class SalePlanTypesResponseModel
    {
        public long SalePlanTypesId { get; set; }
        public string? Title { get; set; }    
        public bool? IsActive { get; set; }
        public string? Code { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
