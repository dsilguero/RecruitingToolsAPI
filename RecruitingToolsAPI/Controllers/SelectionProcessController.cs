using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecruitingToolsAPI.Models;
using RecruitingToolsAPI.Services.Interfaces;

namespace RecruitingToolsAPI.Controllers
{
    [Route("api/selectionprocess")]
    public class SelectionProcessController : Controller
    {
        private readonly ISelectionProcessService _selectionProcessService;

        public SelectionProcessController(ISelectionProcessService selectionProcessService)
        {
            _selectionProcessService = selectionProcessService;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAllSelectionProcesses()
        {
            var selectionProcesses = await _selectionProcessService.GetAllSelectionProcessesAsync();
            return Ok(selectionProcesses);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSelectionProcess(int id)
        {
            var selectionProcess = await _selectionProcessService.GetSelectionProcessByIdAsync(id);
            if (selectionProcess == null)
            {
                return NotFound();
            }
            return Ok(selectionProcess);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSelectionProcess([FromBody] SelectionProcess selectionProcess)
        {
            var newSelectionProcess = await _selectionProcessService.CreateSelectionProcessAsync(selectionProcess);
            return CreatedAtAction(nameof(GetSelectionProcess), new { id = newSelectionProcess });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSelectionProcess(int id, [FromBody] SelectionProcess selectionProcess)
        {
            if (id != selectionProcess.Id)
            {
                return BadRequest();
            }

            var updatedSelectionProcess = await _selectionProcessService.UpdateSelectionProcessAsync(selectionProcess);

            if (updatedSelectionProcess <= 0)
            {
                return NotFound();
            }

            return Ok(updatedSelectionProcess);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSelectionProcess(int id)
        {
            var deleted = await _selectionProcessService.DeleteSelectionProcessAsync(id);
            if (!deleted)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
