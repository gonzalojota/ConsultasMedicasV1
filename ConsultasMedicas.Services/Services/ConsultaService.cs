


using ConsultasMedicas.Core.Entities;
using ConsultasMedicas.Core.Interfaces;
using ConsultasMedicas.Core.Repositories;

public class ConsultaService : IConsultaService
{
    private readonly IConsultaRepository _consultaRepository;

    public ConsultaService(IConsultaRepository consultaRepository)
    {
        _consultaRepository = consultaRepository;
    }

    public async Task<bool> AddConsultaAsync(Consulta consulta)
    {
        return await _consultaRepository.AddConsultaAsync(consulta);
    }

    public async Task<bool> DeleteConsultaAsync(int id)
    {
        return await _consultaRepository.DeleteConsultaAsync(id);
    }

    public async Task<IEnumerable<Consulta>> GetAllConsultasAsync()
    {
        return await _consultaRepository.GetAllConsultasAsync();
    }

    public async Task<Consulta> GetConsultaByIdAsync(int id)
    {
        return await _consultaRepository.GetConsultaByIdAsync(id);
    }

    public async Task<bool> UpdateConsultaAsync(Consulta consulta)
    {
        return await _consultaRepository.UpdateConsultaAsync(consulta);
    }
}