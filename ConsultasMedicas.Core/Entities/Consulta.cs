namespace ConsultasMedicas.Core.Entities
{
    public class Consulta
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public virtual ICollection<ConsultaPaciente> ConsultaPacientes { get; set; }
        public virtual ICollection<ConsultaMedico> ConsultaMedicos { get; set; }
    }
}
