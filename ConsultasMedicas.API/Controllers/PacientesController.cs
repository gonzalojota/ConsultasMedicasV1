using ConsultasMedicas.Common.DTOs;
using ConsultasMedicas.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ConsultasMedicas.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class PacientesController : ControllerBase
    {
        private readonly IPacienteService _pacienteService;
        private readonly ILogger<PacientesController> _logger;

        public PacientesController(IPacienteService pacienteService, ILogger<PacientesController> logger)
        {
            _pacienteService = pacienteService;
            _logger = logger;

        }

        [HttpGet]
        public async Task<ActionResult<List<PacienteDTO>>> GetAll()
        {
            var pacientes = await _pacienteService.GetAllPacientesAsync();

            return Ok(pacientes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PacienteDTO>> GetById(int id)
        {
            var paciente = await _pacienteService.GetPacienteByIdAsync(id);

            if (paciente == null) return NotFound();

            return Ok(paciente);
        }

        [HttpPost]
        public async Task<IActionResult> Create(PacienteCreateDto paciente)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Error de validación: {ModelState}");
                return BadRequest(ModelState);
            }

            var result = await _pacienteService.AddPacienteAsync(paciente);

            if (!result) return BadRequest();

            return Ok(paciente);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, PacienteUpdateDto paciente)
        {
            if (!ModelState.IsValid) return BadRequest();

            var result = await _pacienteService.UpdatePacienteAsync(id, paciente);

            if (!result) return BadRequest();

            return Ok(paciente);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _pacienteService.DeletePacienteAsync(id);

            if (!result) return NotFound();

            return Ok();
        }
    }
}
