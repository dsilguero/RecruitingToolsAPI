using Microsoft.EntityFrameworkCore;
using RecruitingToolsAPI.Models;

namespace RecruitingToolsAPI.Data
{
    public class RecruitingToolsDbContext : DbContext
    {
        public RecruitingToolsDbContext(DbContextOptions<RecruitingToolsDbContext> options) : base(options) { }

        public DbSet<Recruiter> Recruiters { get; set; }
        public DbSet<RecruiterSelectionProcess> RecruiterSelectionProcess { get; set; }

        public DbSet<SelectionProcess> SelectionProcess { get; set; }
        public DbSet<SelectionProcessStatus> SelectionProcessStatuses { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<CandidateSelectionProcess> CandidateSelectionProcess { get; set; }
        public DbSet<CandidateStatus> CandidateStatuses { get; set; }
        public DbSet<Document> Documents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Setting properties
            modelBuilder.Entity<Candidate>(c =>
            {
                c.Property(p => p.LinkedInUrl)
                .IsRequired(false);
            });

            // One to Many relation between SelectionProcess and SelectionProcessStatus
            modelBuilder.Entity<SelectionProcess>()
                .HasOne(sp => sp.Status)
                .WithMany(spt => spt.SelectionProcesses)
                .HasForeignKey(sp => sp.StatusId);

            // One to Many relation between CandidateSelectionProcess and CandidateStatus
            modelBuilder.Entity<CandidateSelectionProcess>()
                .HasOne(cp => cp.CandidateStatus)
                .WithMany(cst => cst.Candidates)
                .HasForeignKey(cp => cp.CandidateStatusId);

            // One to Many relation between Candidate and Document
            modelBuilder.Entity<Document>()
                .HasOne(doc => doc.Candidate)
                .WithMany(doc => doc.Documents)
                .HasForeignKey(doc => doc.CandidateId);

            // One to Many relation between SelectionProcess and Document
            modelBuilder.Entity<Document>()
                .HasOne(doc => doc.SelectionProcess)
                .WithMany(doc => doc.Documents)
                .HasForeignKey(doc => doc.CandidateId);


            // Many to Many relation between Candidate and SelectionProcess (multiple processes of the candidate)
            modelBuilder.Entity<CandidateSelectionProcess>()
                .HasKey(cp => new { cp.CandidateId, cp.SelectionProcessId });

            modelBuilder.Entity<CandidateSelectionProcess>()
                .HasOne(cp => cp.Candidate)
                .WithMany(c => c.SelectionProcesses)
                .HasForeignKey(cp => cp.CandidateId);

            modelBuilder.Entity<CandidateSelectionProcess>()
                .HasOne(cp => cp.SelectionProcess)
                .WithMany(p => p.Candidates)
                .HasForeignKey(cp => cp.SelectionProcessId);

            // Many to Many relation between Recruiter and SelectionProcess (multiple processes of the recruiter)
            modelBuilder.Entity<RecruiterSelectionProcess>()
                .HasKey(rp => new { rp.RecruiterId, rp.SelectionProcessId });

            modelBuilder.Entity<RecruiterSelectionProcess>()
                .HasOne(cp => cp.Recruiter)
                .WithMany(c => c.ManagedProcesses)
                .HasForeignKey(cp => cp.RecruiterId);

            modelBuilder.Entity<RecruiterSelectionProcess>()
                .HasOne(cp => cp.SelectionProcess)
                .WithMany(p => p.Recruiters)
                .HasForeignKey(cp => cp.SelectionProcessId);



            base.OnModelCreating(modelBuilder);
        }
    }
}
