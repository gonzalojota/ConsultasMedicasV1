/*using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ConsultasMedicas.Core.Entities;
using ConsultasMedicas.Core.Interfaces;

namespace ConsultasMedicas.API.Controllers
{
    //[ApiController]
    //[Route("api/[controller]")]
    public class ConsultasController : ControllerBase
    {
        private readonly IConsultaService _consultaService;

        public ConsultasController(IConsultaService consultaService)
        {
            _consultaService = consultaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var consultas = await _consultaService.GetAllConsultasAsync();
            return Ok(consultas);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var consulta = await _consultaService.GetConsultaByIdAsync(id);
            if (consulta == null) return NotFound();
            return Ok(consulta);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Consulta consulta)
        {
            if (!ModelState.IsValid) return BadRequest();
            var result = await _consultaService.AddConsultaAsync(consulta);
            if (!result) return BadRequest();
            return Ok(consulta);
        }

        [HttpPut]
        public async Task<IActionResult> Update(Consulta consulta)
        {
            if (!ModelState.IsValid) return BadRequest();
            var result = await _consultaService.UpdateConsultaAsync(consulta);
            if (!result) return BadRequest();
            return Ok(consulta);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _consultaService.DeleteConsultaAsync(id);
            if (!result) return NotFound();
            return Ok();
        }
    }
}
*/