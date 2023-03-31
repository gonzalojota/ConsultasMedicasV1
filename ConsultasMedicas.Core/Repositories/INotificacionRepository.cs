using ConsultasMedicas.Core.Entities;

namespace ConsultasMedicas.Core.Repositories
{
    public interface INotificacionRepository
    {
        Task<IEnumerable<Notificacion>> GetAllNotificacionesAsync();
        Task<Notificacion> GetNotificacionByIdAsync(int id);
        Task<IEnumerable<Notificacion>> GetNotificacionesByPacienteIdAsync(int pacienteId);
        Task<bool> AddNotificacionAsync(Notificacion notificacion);
        Task<bool> UpdateNotificacionAsync(Notificacion notificacion);
        Task<bool> DeleteNotificacionAsync(int id);
    }
}
