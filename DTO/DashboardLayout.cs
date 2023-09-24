namespace Cizaro_Blazor_Server.DTO
{
    public class DashboardLayout
    {
        public string dashboard_id { get; set; }= string.Empty;
        public string dashboard_name { get; set; }= string.Empty; 
        public string form { get; set; } = string.Empty;
        public int dashboard_type { get; set; } = 0;
        public int version { get; set; } = 0;   
        public int form_id { get; set;} = 0;
        public string visibleBy_users { get; set; } = string.Empty;
        public string visibleBy_roles { get; set;} = string.Empty;
        public bool showOnForm { get; set; }    
        public string report_module_id { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty; 
        public bool showOnWeb { get; set; }
        public  bool lockdashboardDesigner { get; set; }        
        public bool showOnPOS { get; set; } 
        public string startup_roles_ids { get; set; } = string.Empty;   
        public string feature_id { get; set; } = string.Empty;   
        public string dashboard_layout_xml { get; set; } = string.Empty;


    }
}
