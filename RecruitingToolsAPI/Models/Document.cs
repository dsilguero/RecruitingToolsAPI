using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecruitingToolsAPI.Models
{
    public class Document
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int DocumentId { get; set; }
        public string Name { get; set; }
        public byte[] Content { get; set; }
        public int CandidateId { get; set; }
        public int SelectionProcessId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


        public Candidate Candidate { get; set; }
        public SelectionProcess SelectionProcess { get; set; }

        public override string ToString()
        {
            return $"Recruiter: Id={DocumentId}, Name={Name}";
        }
    }
}
