using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultasMedicas.Core.Interfaces
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
