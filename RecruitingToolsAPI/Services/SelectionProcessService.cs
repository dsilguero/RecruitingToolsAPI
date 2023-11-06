using RecruitingToolsAPI.Models;
using RecruitingToolsAPI.Repositories.Interfaces;
using RecruitingToolsAPI.Services.Interfaces;

namespace RecruitingToolsAPI.Services
{
    public class SelectionProcessService : ISelectionProcessService
    {
        private readonly ISelectionProcessRepository _selectionProcessRepository;
        private readonly ISelectionProcessStatusRepository _selectionProcessStatus;

        public SelectionProcessService(ISelectionProcessRepository repository, ISelectionProcessStatusRepository selectionProcessStatus)
        {
            _selectionProcessRepository = repository;
            _selectionProcessStatus = selectionProcessStatus;
        }

        public async Task<SelectionProcess> GetSelectionProcessByIdAsync(int id)
        {
            return await _selectionProcessRepository.GetByIdAsync(id);
        }

        public async Task<List<SelectionProcess>> GetAllSelectionProcessesAsync()
        {
            return await _selectionProcessRepository.GetAllAsync();
        }

        public async Task<int> CreateSelectionProcessAsync(SelectionProcess process)
        {
            if(process.Status == null)
            {
                process.Status = await _selectionProcessStatus.GetByIdAsync(process.StatusId);

            }
            return await _selectionProcessRepository.AddAsync(process);
        }

        public async Task<int> UpdateSelectionProcessAsync(SelectionProcess process)
        {
            return await _selectionProcessRepository.UpdateAsync(process);
        }

        public async Task<bool> DeleteSelectionProcessAsync(int id)
        {
            return await _selectionProcessRepository.DeleteAsync(id);
        }

        public async Task<List<CandidateSelectionProcess>> GetSelectionProcessCandidates(int id)
        {
            return await _selectionProcessRepository.GetCandidates(id);
        }
    }
}
