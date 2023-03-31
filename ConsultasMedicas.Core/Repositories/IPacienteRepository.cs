using ConsultasMedicas.Core.Entities;

namespace ConsultasMedicas.Core.Repositories
{
    public interface IPacienteRepository
    {
        Task<IEnumerable<Paciente>> GetAllPacientesAsync();
        Task<Paciente> GetPacienteByIdAsync(int id);
        Task<bool> AddPacienteAsync(Paciente paciente);
        Task<bool> UpdatePacienteAsync(Paciente paciente);
        Task<bool> DeletePacienteAsync(int id);
    }
}
