




using ConsultasMedicas.Core.Entities;
using ConsultasMedicas.Core.Interfaces;
using ConsultasMedicas.Core.Repositories;

public class MedicoService : IMedicoService
{
    private readonly IMedicoRepository _medicoRepository;

    public MedicoService(IMedicoRepository medicoRepository)
    {
        _medicoRepository = medicoRepository;
    }

    public async Task<bool> AddMedicoAsync(Medico medico)
    {
        return await _medicoRepository.AddMedicoAsync(medico);
    }

    public async Task<bool> DeleteMedicoAsync(int id)
    {
        return await _medicoRepository.DeleteMedicoAsync(id);
    }

    public async Task<IEnumerable<Medico>> GetAllMedicosAsync()
    {
        return await _medicoRepository.GetAllMedicosAsync();
    }

    public async Task<Medico> GetMedicoByIdAsync(int id)
    {
        return await _medicoRepository.GetMedicoByIdAsync(id);
    }

    public async Task<bool> UpdateMedicoAsync(Medico medico)
    {
        return await _medicoRepository.UpdateMedicoAsync(medico);
    }
}
