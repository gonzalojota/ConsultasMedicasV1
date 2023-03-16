using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ConsultasMedicas.Core.Entities;
using ConsultasMedicas.Core.Interfaces;

namespace ConsultasMedicas.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PacientesController : ControllerBase
    {
        private readonly IPacienteService _pacienteService;

        public PacientesController(IPacienteService pacienteService)
        {
            _pacienteService = pacienteService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var pacientes = await _pacienteService.GetAllPacientesAsync();
            return Ok(pacientes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var paciente = await _pacienteService.GetPacienteByIdAsync(id);
            if (paciente == null) return NotFound();
            return Ok(paciente);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Paciente paciente)
        {
            if (!ModelState.IsValid) return BadRequest();
            var result = await _pacienteService.AddPacienteAsync(paciente);
            if (!result) return BadRequest();
            return Ok(paciente);
        }

        [HttpPut]
        public async Task<IActionResult> Update(Paciente paciente)
        {
            if (!ModelState.IsValid) return BadRequest();
            var result = await _pacienteService.UpdatePacienteAsync(paciente);
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
