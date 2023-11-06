using RecruitingToolsAPI.Models;

namespace RecruitingToolsAPI.Repositories.Interfaces
{
    public interface ISelectionProcessRepository
    {
        Task<SelectionProcess> GetByIdAsync(int processId);
        Task<List<SelectionProcess>> GetAllAsync();
        Task<List<CandidateSelectionProcess>> GetCandidates(int processId);
        Task<int> AddAsync(SelectionProcess process);
        Task<int> UpdateAsync(SelectionProcess process);
        Task<bool> DeleteAsync(int id);
    }
}
