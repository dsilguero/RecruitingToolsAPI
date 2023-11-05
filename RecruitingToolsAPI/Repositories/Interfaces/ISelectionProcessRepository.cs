using RecruitingToolsAPI.Models;

namespace RecruitingToolsAPI.Repositories.Interfaces
{
    public interface ISelectionProcessRepository
    {
        Task<SelectionProcess> GetByIdAsync(int id);
        Task<List<SelectionProcess>> GetAllAsync();
        Task<int> AddAsync(SelectionProcess process);
        Task<int> UpdateAsync(SelectionProcess process);
        Task<bool> DeleteAsync(int id);
    }
}
