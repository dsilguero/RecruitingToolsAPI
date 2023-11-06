using Microsoft.EntityFrameworkCore;
using RecruitingToolsAPI.Data;
using RecruitingToolsAPI.Models;
using RecruitingToolsAPI.Repositories.Interfaces;

namespace RecruitingToolsAPI.Repositories
{
    public class SelectionProcessRepository : ISelectionProcessRepository
    {
        private readonly RecruitingToolsDbContext _context;

        public SelectionProcessRepository(RecruitingToolsDbContext context) 
        {
            _context = context;
        }

        public async Task<SelectionProcess> GetByIdAsync(int processId)
        {
            return await _context.SelectionProcess
                                 .Include(sp => sp.Status)
                                 .Include(sp => sp.Recruiters)
                                 .Include(sp => sp.Documents)
                                 .Include(sp => sp.Candidates)
                                 .FirstAsync(sp => sp.Id == processId);

        }

        public async Task<List<SelectionProcess>> GetAllAsync()
        {
            return await _context.SelectionProcess
                        .Include(sp => sp.Candidates)
                        .Include(sp => sp.Recruiters)
                        .Include(sp => sp.Documents)
                        .Include(sp => sp.Status)
                        .ToListAsync();
        }

        public async Task<int> AddAsync(SelectionProcess process)
        {
            _context.SelectionProcess.Add(process);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateAsync(SelectionProcess process)
        {
            _context.Entry(process).State = EntityState.Modified;
            return await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var process = await _context.SelectionProcess.FindAsync(id);
            var res = false;

            if (process != null)
            {
                _context.SelectionProcess.Remove(process);
                await _context.SaveChangesAsync();
                res = true;
            }

            return res;
        }

        public async Task<List<CandidateSelectionProcess>> GetCandidates(int processId)
        {
            var process = await _context.SelectionProcess
                                .Include(sp => sp.Candidates)
                                .Include(sp => sp.Documents)
                                .FirstAsync(x => x.Id == processId);

            return process.Candidates ?? new List<CandidateSelectionProcess>();
        }
    }

}
