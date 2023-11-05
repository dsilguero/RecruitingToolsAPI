namespace RecruitingToolsAPI.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string LinkedInUrl { get; set; }
            
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


        
        public List<Document> Documents { get; set; }
        public List<CandidateSelectionProcess> SelectionProcesses { get; set; }
    }
}
