using ConsultasMedicas.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConsultasMedicas.Data.Context
{
    public class ConsultasMedicasDbContext : DbContext
    {
        public ConsultasMedicasDbContext(DbContextOptions<ConsultasMedicasDbContext> options) : base(options)
        {
        }

        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Notificacion> Notificaciones { get; set; }
        public DbSet<ConsultaPaciente> ConsultasPacientes { get; set; }
        public DbSet<ConsultaMedico> ConsultasMedicos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ConsultaPaciente>()
                .HasKey(cp => new { cp.ConsultaId, cp.PacienteId });

            modelBuilder.Entity<ConsultaPaciente>()
                .HasOne(cp => cp.Consulta)
                .WithMany(c => c.ConsultaPacientes)
                .HasForeignKey(cp => cp.ConsultaId);

            modelBuilder.Entity<ConsultaPaciente>()
                .HasOne(cp => cp.Paciente)
                .WithMany(p => p.ConsultaPacientes)
                .HasForeignKey(cp => cp.PacienteId);

            modelBuilder.Entity<ConsultaMedico>()
                .HasKey(cm => new { cm.ConsultaId, cm.MedicoId });

            modelBuilder.Entity<ConsultaMedico>()
                .HasOne(cm => cm.Consulta)
                .WithMany(c => c.ConsultaMedicos)
                .HasForeignKey(cm => cm.ConsultaId);

            modelBuilder.Entity<ConsultaMedico>()
                .HasOne(cm => cm.Medico)
                .WithMany(m => m.ConsultaMedicos)
                .HasForeignKey(cm => cm.MedicoId);
        }
    }
}