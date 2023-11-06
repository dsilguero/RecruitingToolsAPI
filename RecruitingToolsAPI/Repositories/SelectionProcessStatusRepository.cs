using Microsoft.EntityFrameworkCore;
using RecruitingToolsAPI.Data;
using RecruitingToolsAPI.Models;
using RecruitingToolsAPI.Repositories.Interfaces;

namespace RecruitingToolsAPI.Repositories
{
    public class SelectionProcessStatusRepository : ISelectionProcessStatusRepository
    {
        private readonly RecruitingToolsDbContext _context;

        public SelectionProcessStatusRepository(RecruitingToolsDbContext context)
        {
            _context = context;
        }

        public async Task<List<SelectionProcessStatus>> GetAllAsync()
        {
            return await _context.SelectionProcessStatuses.ToListAsync();
        }

        public async Task<SelectionProcessStatus> GetByIdAsync(int id)
        {
            return await _context.SelectionProcessStatuses.FindAsync(id);
        }
    }
}
