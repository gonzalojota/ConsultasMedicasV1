namespace ConsultasMedicas.Common.DTOs
{
    public class PacienteDTO : PacienteCreateDto
    {
        public int Id { get; set; }

        public DateTime FechaCreacion { get; set; }

        public DateTime FechaModificacion { get; set; }

    }

}