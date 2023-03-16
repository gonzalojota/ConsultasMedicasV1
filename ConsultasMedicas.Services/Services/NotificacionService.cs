

public class NotificacionService : INotificacionService
{
    private readonly INotificacionRepository _notificacionRepository;

    public NotificacionService(INotificacionRepository notificacionRepository)
    {
        _notificacionRepository = notificacionRepository;
    }

    public async Task<bool> AddNotificacionAsync(Notificacion notificacion)
    {
        return await _notificacionRepository.AddNotificacionAsync(notificacion);
    }
    public async Task<bool> DeleteNotificacionAsync(int id)
    {
        return await _notificacionRepository.DeleteNotificacionAsync(id);
    }

    public async Task<IEnumerable<Notificacion>> GetAllNotificacionesAsync()
    {
        return await _notificacionRepository.GetAllNotificacionesAsync();
    }

    public async Task<Notificacion> GetNotificacionByIdAsync(int id)
    {
        return await _notificacionRepository.GetNotificacionByIdAsync(id);
    }

    public async Task<IEnumerable<Notificacion>> GetNotificacionesByPacienteIdAsync(int pacienteId)
    {
        return await _notificacionRepository.GetNotificacionesByPacienteIdAsync(pacienteId);
    }

    public async Task<bool> UpdateNotificacionAsync(Notificacion notificacion)
    {
        return await _notificacionRepository.UpdateNotificacionAsync(notificacion);
    }
}