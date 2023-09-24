namespace Cizaro_Blazor_Server.DTO
{
    public class ReportLayout
    {
        public string report_id { get; set; } = string.Empty;
        public string report_name { get; set; } = string.Empty;
        public bool showOnWeb { get; set; }
        public bool labelReport { get; set; }
        public bool showOnForm { get; set; }
        public bool showOnPOS { get; set; }
        public string visibleBy_roles { get; set; } = string.Empty;
        public int printerMarginLeft { get; set; } = 0;
        public int printerMarginRight { get; set; } = 0;
        public int printerMarginTop { get; set; } = 0;
        public decimal reportsScaleFactor { get; set; } = 0;
        public int no_copies { get; set; }

        public bool lockReport { get; set; } = false;
        public bool printAutomaticly { get; set; } = false;
        public bool useDefaultSettings { get; set; } = false;
        public bool showEmailForm { get; set; } = false;
        public string emailtoSendReport { get; set; } = string.Empty;
        public string label_report_code { get; set; } = string.Empty;
        public bool audit_report { get; set; }
        public bool save_report_for_auditing { get; set; }
        public string report_module_id { get; set; } = string.Empty;
        public string feature_id { get; set; } = string.Empty;
        public string copies_quantity_field { get; set; } = string.Empty;
        public bool printPreview { get; set; }
        public string report_layout_xml { get; set; } = string.Empty;
    }
}
