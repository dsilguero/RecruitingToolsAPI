namespace RecruitingToolsAPI.Models
{
    public class RecruiterSelectionProcess
    {
        public int RecruiterId { get; set; }
        public int SelectionProcessId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Recruiter Recruiter { get; set; }
        public SelectionProcess SelectionProcess { get; set; }
    }
}