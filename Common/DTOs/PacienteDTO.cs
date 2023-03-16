namespace ConsultasMedicas.Common.DTOs
{
    public class PacienteDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }

        public string Telefono { get; set; }
    }
}