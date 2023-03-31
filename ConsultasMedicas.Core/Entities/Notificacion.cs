namespace ConsultasMedicas.Core.Entities
{
    public class Notificacion
    {
        public int Id { get; set; }
        public int PacienteId { get; set; }
        public string Mensaje { get; set; }
        public DateTime FechaEnvio { get; set; }
        public bool Enviada { get; set; }
        public virtual Paciente Paciente { get; set; }
    }
}
