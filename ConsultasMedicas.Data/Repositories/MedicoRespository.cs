using System.Collections.Generic;
using System.Threading.Tasks;
using ConsultasMedicas.Core.Entities;
using ConsultasMedicas.Core.Interfaces;
using ConsultasMedicas.Data.Context;
using Microsoft.EntityFrameworkCore;

public class MedicoRepository : IMedicoRepository
{
    private readonly ConsultasMedicasDbContext _context;

    public MedicoRepository(ConsultasMedicasDbContext context)
    {
        _context = context;
    }

    public async Task<bool> AddMedicoAsync(Medico medico)
    {
        await _context.Medicos.AddAsync(medico);
        return await _context.SaveChangesAsync() > 0;
    }
    public async Task<bool> DeleteMedicoAsync(int id)
    {
        var medico = await _context.Medicos.FindAsync(id);
        if (medico != null)
        {
            _context.Medicos.Remove(medico);
            return await _context.SaveChangesAsync() > 0;
        }

        return false;
    }

    public async Task<IEnumerable<Medico>> GetAllMedicosAsync()
    {
        return await _context.Medicos.ToListAsync();
    }

    public async Task<Medico> GetMedicoByIdAsync(int id)
    {
        return await _context.Medicos.FindAsync(id);
    }

    public async Task<bool> UpdateMedicoAsync(Medico medico)
    {
        _context.Entry(medico).State = EntityState.Modified;
        return await _context.SaveChangesAsync() > 0;
    }
}