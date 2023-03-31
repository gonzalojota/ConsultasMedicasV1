using ConsultasMedicas.Core.Entities;

namespace ConsultasMedicas.Core.Repositories
{
    public interface IConsultaRepository
    {
        Task<IEnumerable<Consulta>> GetAllConsultasAsync();
        Task<Consulta> GetConsultaByIdAsync(int id);
        Task<bool> AddConsultaAsync(Consulta consulta);
        Task<bool> UpdateConsultaAsync(Consulta consulta);
        Task<bool> DeleteConsultaAsync(int id);
    }
}
