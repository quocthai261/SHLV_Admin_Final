namespace AdminWeb.Models.Menu
{
    public class SiteMapNode
    {
        public long ID { get; set; }
        public long? PARENTID { get; set; }
        public string CONTENT { get; set; }
        public string ICONCLASS { get; set; }
        public string URL { get; set; }
        public string URL_ { get; set; }
        public int? ORDER { get; set; }
        public long ORDER_ { get; set; }
        public bool ACTIVE { get; set; }
        public bool ISACTIVE { get; set; }
        public bool ISDISPLAY { get; set; }
        public string SYSTEMNAME { get; set; } = string.Empty;
    }
}
