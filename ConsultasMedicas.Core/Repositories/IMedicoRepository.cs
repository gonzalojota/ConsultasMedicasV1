using ConsultasMedicas.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultasMedicas.Core.Repositories
{
    public interface IMedicoRepository
    {
        Task<IEnumerable<Medico>> GetAllMedicosAsync();
        Task<Medico> GetMedicoByIdAsync(int id);
        Task<bool> AddMedicoAsync(Medico medico);
        Task<bool> UpdateMedicoAsync(Medico medico);
        Task<bool> DeleteMedicoAsync(int id);
    }
}
