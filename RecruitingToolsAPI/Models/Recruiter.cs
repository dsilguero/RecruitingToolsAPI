using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecruitingToolsAPI.Models
{
    public class Recruiter
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public List<RecruiterSelectionProcess> ManagedProcesses { get; set; }

        public override string ToString()
        {
            return $"Recruiter: Id={Id}, Name={Name}, Surname={Surname}";
        }
    }
}
