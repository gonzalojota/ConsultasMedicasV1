

public class PacienteService : IPacienteService
{
    private readonly IPacienteRepository _pacienteRepository;

    public PacienteService(IPacienteRepository pacienteRepository)
    {
        _pacienteRepository = pacienteRepository;
    }

    public async Task<bool> AddPacienteAsync(Paciente paciente)
    {
        return await _pacienteRepository.AddPacienteAsync(paciente);
    }

    public async Task<bool> DeletePacienteAsync(int id)
    {
        return await _pacienteRepository.DeletePacienteAsync(id);
    }

    public async Task<IEnumerable<Paciente>> GetAllPacientesAsync()
    {
        return await _pacienteRepository.GetAllPacientesAsync();
    }

    public async Task<Paciente> GetPacienteByIdAsync(int id)
    {
        return await _pacienteRepository.GetPacienteByIdAsync(id);
    }

    public async Task<bool> UpdatePacienteAsync(Paciente paciente)
    {
        return await _pacienteRepository.UpdatePacienteAsync(paciente);
    }
}