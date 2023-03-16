using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ConsultasMedicas.Core.Entities;
using ConsultasMedicas.Core.Interfaces;

namespace ConsultasMedicas.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MedicosController : ControllerBase
    {
        private readonly IMedicoService _medicoService;

        public MedicosController(IMedicoService medicoService)
        {
            _medicoService = medicoService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var medicos = await _medicoService.GetAllMedicosAsync();
            return Ok(medicos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var medico = await _medicoService.GetMedicoByIdAsync(id);
            if (medico == null) return NotFound();
            return Ok(medico);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Medico medico)
        {
            if (!ModelState.IsValid) return BadRequest();
            var result = await _medicoService.AddMedicoAsync(medico);
            if (!result) return BadRequest();
            return Ok(medico);
        }

        [HttpPut]
        public async Task<IActionResult> Update(Medico medico)
        {
            if (!ModelState.IsValid) return BadRequest();
            var result = await _medicoService.UpdateMedicoAsync(medico);
            if (!result) return BadRequest();
            return Ok(medico);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _medicoService.DeleteMedicoAsync(id);
            if (!result) return NotFound();
            return Ok();
        }
    }
}
