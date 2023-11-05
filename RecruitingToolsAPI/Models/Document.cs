namespace RecruitingToolsAPI.Models
{
    public class Document
    {
        public int DocumentId { get; set; }
        public string Name { get; set; }
        public byte[] Content { get; set; }
        public int CandidateId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


        public Candidate Candidate { get; set; }
    }
}
