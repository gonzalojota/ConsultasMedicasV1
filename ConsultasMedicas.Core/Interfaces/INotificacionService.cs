using ConsultasMedicas.Core.Entities;

namespace ConsultasMedicas.Core.Interfaces
{
    public interface INotificacionService
    {
        Task<IEnumerable<Notificacion>> GetAllNotificacionesAsync();
        Task<Notificacion> GetNotificacionByIdAsync(int id);
        Task<bool> AddNotificacionAsync(Notificacion notificacion);
        Task<bool> UpdateNotificacionAsync(Notificacion notificacion);
        Task<bool> DeleteNotificacionAsync(int id);
    }
}
