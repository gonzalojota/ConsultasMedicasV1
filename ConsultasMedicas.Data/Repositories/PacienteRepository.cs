using System.Collections.Generic;
using System.Threading.Tasks;
using ConsultasMedicas.Core.Entities;
using ConsultasMedicas.Core.Interfaces;
using ConsultasMedicas.Data.Context;
using Microsoft.EntityFrameworkCore;


namespace ConsultasMedicas.Data.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly ConsultasMedicasDbContext _context;

        public PacienteRepository(ConsultasMedicasDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddPacienteAsync(Paciente paciente)
        {
            await _context.Pacientes.AddAsync(paciente);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeletePacienteAsync(int id)
        {
            var paciente = await _context.Pacientes.FindAsync(id);
            if (paciente != null)
            {
                _context.Pacientes.Remove(paciente);
                return await _context.SaveChangesAsync() > 0;
            }

            return false;
        }

        public async Task<IEnumerable<Paciente>> GetAllPacientesAsync()
        {
            return await _context.Pacientes.ToListAsync();
        }

        public async Task<Paciente> GetPacienteByIdAsync(int id)
        {
            return await _context.Pacientes.FindAsync(id);
        }

        public async Task<bool> UpdatePacienteAsync(Paciente paciente)
        {
            _context.Entry(paciente).State = EntityState.Modified;
            return await _context.SaveChangesAsync() > 0;
        }
    }
}