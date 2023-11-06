using RecruitingToolsAPI.Models;

namespace RecruitingToolsAPI.Repositories.Interfaces
{
    public interface ISelectionProcessStatusRepository
    {
        Task<SelectionProcessStatus> GetByIdAsync(int id);
        Task<List<SelectionProcessStatus>> GetAllAsync();
    }
}
