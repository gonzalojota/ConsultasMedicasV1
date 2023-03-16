using ConsultasMedicas.Common.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsultasMedicas.Core.Interfaces
{
    public interface IPacienteService
    {
        Task<IEnumerable<PacienteDTO>> GetAllPacientesAsync();
        Task<PacienteDTO> GetPacienteByIdAsync(int id);
        Task<bool> AddPacienteAsync(PacienteCreacionalDTO paciente);
        Task<bool> UpdatePacienteAsync(int id, PacienteCreacionalDTO paciente);
        Task<bool> DeletePacienteAsync(int id);
    }
}
