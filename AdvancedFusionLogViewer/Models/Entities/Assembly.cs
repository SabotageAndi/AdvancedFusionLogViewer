namespace AdvancedFusionLogViewer.Models.Entities
{
    public class Assembly
    {
        public string FullName { get; set; }
        public Process Process { get; set; }
        public string LogFilePath { get; set; }
    }
}