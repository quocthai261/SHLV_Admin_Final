namespace AdminWeb.Dtos.ApiResponse
{
    public class CriteriasResponseModel
    {
        public long CriteriaId { get; set; }    

        public string CriteriaContent { get; set; } 

        public int CriteriaType { get; set; }    

        public string CriteriaCode { get; set; }

        public string Icon { get; set; }

        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
