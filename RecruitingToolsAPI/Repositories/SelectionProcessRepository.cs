using Microsoft.EntityFrameworkCore;
using RecruitingToolsAPI.Data;
using RecruitingToolsAPI.Models;
using RecruitingToolsAPI.Repositories.Interfaces;

namespace RecruitingToolsAPI.Repositories
{
    public class SelectionProcessRepository : ISelectionProcessRepository
    {
        private readonly RecruitingToolsDbContext _context; // Reemplaza YourDbContext con el contexto de tu base de datos.

        public SelectionProcessRepository(RecruitingToolsDbContext context) // Inyecta el DbContext en el constructor.
        {
            _context = context;
        }

        public async Task<SelectionProcess> GetByIdAsync(int id)
        {
            return await _context.SelectionProcesses.FindAsync(id);
        }

        public async Task<List<SelectionProcess>> GetAllAsync()
        {
            return await _context.SelectionProcesses.ToListAsync();
        }

        public async Task<int> AddAsync(SelectionProcess process)
        {
            _context.SelectionProcesses.Add(process);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateAsync(SelectionProcess process)
        {
            _context.Entry(process).State = EntityState.Modified;
            return await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var process = await _context.SelectionProcesses.FindAsync(id);
            var res = false;

            if (process != null)
            {
                _context.SelectionProcesses.Remove(process);
                await _context.SaveChangesAsync();
                res = true;
            }

            return res;
        }
    }

}
