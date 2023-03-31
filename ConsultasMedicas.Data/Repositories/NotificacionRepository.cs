using ConsultasMedicas.Core.Entities;
using ConsultasMedicas.Core.Repositories;
using ConsultasMedicas.Data.Context;
using Microsoft.EntityFrameworkCore;

public class NotificacionRepository : INotificacionRepository
{
    private readonly ConsultasMedicasDbContext _context;

    public NotificacionRepository(ConsultasMedicasDbContext context)
    {
        _context = context;
    }

    public async Task<bool> AddNotificacionAsync(Notificacion notificacion)
    {
        await _context.Notificaciones.AddAsync(notificacion);
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> DeleteNotificacionAsync(int id)
    {
        var notificacion = await _context.Notificaciones.FindAsync(id);
        if (notificacion != null)
        {
            _context.Notificaciones.Remove(notificacion);
            return await _context.SaveChangesAsync() > 0;
        }

        return false;
    }

    public async Task<IEnumerable<Notificacion>> GetAllNotificacionesAsync()
    {
        return await _context.Notificaciones.Include(n => n.Paciente).ToListAsync();
    }

    public async Task<Notificacion> GetNotificacionByIdAsync(int id)
    {
        return await _context.Notificaciones.Include(n => n.Paciente).FirstOrDefaultAsync(n => n.Id == id);
    }

    public async Task<IEnumerable<Notificacion>> GetNotificacionesByPacienteIdAsync(int pacienteId)
    {
        return await _context.Notificaciones
            .Include(n => n.Paciente)
            .Where(n => n.PacienteId == pacienteId)
            .ToListAsync();
    }

    public async Task<bool> UpdateNotificacionAsync(Notificacion notificacion)
    {
        _context.Entry(notificacion).State = EntityState.Modified;
        return await _context.SaveChangesAsync() > 0;
    }
}