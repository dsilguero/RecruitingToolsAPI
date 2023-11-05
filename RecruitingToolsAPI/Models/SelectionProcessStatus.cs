namespace RecruitingToolsAPI.Models
{
    public class SelectionProcessStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<SelectionProcess> SelectionProcesses { get; set; }
    }
}
