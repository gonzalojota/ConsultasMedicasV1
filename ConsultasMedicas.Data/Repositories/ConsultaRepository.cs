using ConsultasMedicas.Core.Entities;
using ConsultasMedicas.Core.Repositories;
using ConsultasMedicas.Data.Context;
using Microsoft.EntityFrameworkCore;

public class ConsultaRepository : IConsultaRepository
{
    private readonly ConsultasMedicasDbContext _context;

    public ConsultaRepository(ConsultasMedicasDbContext context)
    {
        _context = context;
    }

    public async Task<bool> AddConsultaAsync(Consulta consulta)
    {
        await _context.Consultas.AddAsync(consulta);
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> DeleteConsultaAsync(int id)
    {
        var consulta = await _context.Consultas.FindAsync(id);
        if (consulta != null)
        {
            _context.Consultas.Remove(consulta);
            return await _context.SaveChangesAsync() > 0;
        }

        return false;
    }

    public async Task<IEnumerable<Consulta>> GetAllConsultasAsync()
    {
        return await _context.Consultas
            .Include(c => c.ConsultaPacientes)
            .ThenInclude(cp => cp.Paciente)
            .Include(c => c.ConsultaMedicos)
            .ThenInclude(cm => cm.Medico)
            .ToListAsync();
    }

    public async Task<Consulta> GetConsultaByIdAsync(int id)
    {
        return await _context.Consultas
            .Include(c => c.ConsultaPacientes)
            .ThenInclude(cp => cp.Paciente)
            .Include(c => c.ConsultaMedicos)
            .ThenInclude(cm => cm.Medico)
            .FirstOrDefaultAsync(c => c.Id == id);
    }

    public async Task<bool> UpdateConsultaAsync(Consulta consulta)
    {
        _context.Entry(consulta).State = EntityState.Modified;
        return await _context.SaveChangesAsync() > 0;
    }
}

