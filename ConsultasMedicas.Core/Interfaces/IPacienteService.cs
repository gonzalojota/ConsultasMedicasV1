using ConsultasMedicas.Common.DTOs;

namespace ConsultasMedicas.Core.Interfaces
{
    public interface IPacienteService
    {
        Task<IEnumerable<PacienteDTO>> GetAllPacientesAsync();
        Task<PacienteDTO> GetPacienteByIdAsync(int id);
        Task<bool> AddPacienteAsync(PacienteCreateDto paciente);
        Task<bool> UpdatePacienteAsync(int id, PacienteUpdateDto paciente);
        Task<bool> DeletePacienteAsync(int id);
    }
}
