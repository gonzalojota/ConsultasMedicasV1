using ConsultasMedicas.Core.Entities;

namespace ConsultasMedicas.Core.Interfaces
{
    public interface IMedicoService
    {
        Task<IEnumerable<Medico>> GetAllMedicosAsync();
        Task<Medico> GetMedicoByIdAsync(int id);
        Task<bool> AddMedicoAsync(Medico medico);
        Task<bool> UpdateMedicoAsync(Medico medico);
        Task<bool> DeleteMedicoAsync(int id);
    }
}
