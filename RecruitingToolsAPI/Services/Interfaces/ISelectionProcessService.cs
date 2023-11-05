using RecruitingToolsAPI.Models;

namespace RecruitingToolsAPI.Services.Interfaces
{
    public interface ISelectionProcessService
    {
        Task<SelectionProcess> GetSelectionProcessByIdAsync(int id);
        Task<List<SelectionProcess>> GetAllSelectionProcessesAsync();
        Task<int> CreateSelectionProcessAsync(SelectionProcess process);
        Task<int> UpdateSelectionProcessAsync(SelectionProcess process);
        Task<bool> DeleteSelectionProcessAsync(int id);
    }
}
