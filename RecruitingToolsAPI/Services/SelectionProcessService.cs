using RecruitingToolsAPI.Models;
using RecruitingToolsAPI.Repositories.Interfaces;
using RecruitingToolsAPI.Services.Interfaces;

namespace RecruitingToolsAPI.Services
{
    public class SelectionProcessService : ISelectionProcessService
    {
        private readonly ISelectionProcessRepository _repository;

        public SelectionProcessService(ISelectionProcessRepository repository)
        {
            _repository = repository;
        }

        public async Task<SelectionProcess> GetSelectionProcessByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<List<SelectionProcess>> GetAllSelectionProcessesAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<int> CreateSelectionProcessAsync(SelectionProcess process)
        {
            return await _repository.AddAsync(process);
        }

        public async Task<int> UpdateSelectionProcessAsync(SelectionProcess process)
        {
            return await _repository.UpdateAsync(process);
        }

        public async Task<bool> DeleteSelectionProcessAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
