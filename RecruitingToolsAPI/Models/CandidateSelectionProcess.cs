namespace RecruitingToolsAPI.Models
{
    public class CandidateSelectionProcess
    {
        public int CandidateId { get; set; }
        public int SelectionProcessId { get; set; }
        public int CandidateStatusId { get; set; }
        public DateTime CandidateIntroductionDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


        public CandidateStatus CandidateStatus { get; set; }
        public Candidate Candidate { get; set; }
        public SelectionProcess SelectionProcess { get; set; }
    }
}
