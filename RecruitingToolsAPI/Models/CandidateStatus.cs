namespace RecruitingToolsAPI.Models
{
    public class CandidateStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<CandidateSelectionProcess> Candidates { get; set; }
    }
}
