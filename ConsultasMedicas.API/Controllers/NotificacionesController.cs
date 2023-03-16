using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ConsultasMedicas.Core.Entities;
using ConsultasMedicas.Core.Interfaces;

namespace ConsultasMedicas.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotificacionesController : ControllerBase
    {
        private readonly INotificacionService _notificacionService;

        public NotificacionesController(INotificacionService notificacionService)
        {
            _notificacionService = notificacionService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var notificaciones = await _notificacionService.GetAllNotificacionesAsync();
            return Ok(notificaciones);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var notificacion = await _notificacionService.GetNotificacionByIdAsync(id);
            if (notificacion == null) return NotFound();
            return Ok(notificacion);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Notificacion notificacion)
        {
            if (!ModelState.IsValid) return BadRequest();
            var result = await _notificacionService.AddNotificacionAsync(notificacion);
            if (!result) return BadRequest();
            return Ok(notificacion);
        }

        [HttpPut]
        public async Task<IActionResult> Update(Notificacion notificacion)
        {
            if (!ModelState.IsValid) return BadRequest();
            var result = await _notificacionService.UpdateNotificacionAsync(notificacion);
            if (!result) return BadRequest();
            return Ok(notificacion);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _notificacionService.DeleteNotificacionAsync(id);
            if (!result) return NotFound();
            return Ok();
        }
    }
}
