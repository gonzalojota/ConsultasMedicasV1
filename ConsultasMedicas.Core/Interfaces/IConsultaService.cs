using System.Collections.Generic;
using System.Threading.Tasks;
using ConsultasMedicas.Core.Entities;

namespace ConsultasMedicas.Core.Interfaces
{
    public interface IConsultaService
    {
        Task<IEnumerable<Consulta>> GetAllConsultasAsync();
        Task<Consulta> GetConsultaByIdAsync(int id);
        Task<bool> AddConsultaAsync(Consulta consulta);
        Task<bool> UpdateConsultaAsync(Consulta consulta);
        Task<bool> DeleteConsultaAsync(int id);
    }
}
