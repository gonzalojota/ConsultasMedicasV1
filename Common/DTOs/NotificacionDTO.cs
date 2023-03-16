namespace ConsultasMedicas.Common.DTOs
{
    public class NotificacionDTO
    {
        public int Id { get; set; }
        public int PacienteId { get; set; }
        public string Mensaje { get; set; }
    }
}