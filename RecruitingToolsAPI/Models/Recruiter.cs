namespace RecruitingToolsAPI.Models
{
    public class Recruiter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public List<RecruiterSelectionProcess> ManagedProcesses { get; set; }
    }
}
