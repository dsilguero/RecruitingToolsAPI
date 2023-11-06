using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecruitingToolsAPI.Models
{
    public class SelectionProcess
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int StatusId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


        public SelectionProcessStatus Status { get; set; }
        public List<RecruiterSelectionProcess> Recruiters { get; set; }

        public List<CandidateSelectionProcess> Candidates { get; set; }
        public List<Document> Documents { get; set; }

        public override string ToString()
        {
            return $"SelectionProcess: Id={Id}, Name={Name}, StartDate={StartDate}";
        }
    }
}
