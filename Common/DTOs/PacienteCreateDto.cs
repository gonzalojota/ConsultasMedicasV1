using System.ComponentModel.DataAnnotations;

namespace ConsultasMedicas.Common.DTOs
{
    // PacienteCreateDto
    public class PacienteCreateDto
    {
        [Required]
        [MaxLength(50)]
        public string PrimerNombre { get; set; }

        [MaxLength(50)]
        public string? SegundoNombre { get; set; }

        [Required]
        [MaxLength(50)]
        public string PrimerApellido { get; set; }

        [MaxLength(50)]
        public string? SegundoApellido { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string? Email { get; set; }

        [Phone]
        [MaxLength(20)]
        public string? Telefono { get; set; }

        public Boolean RecibeEmailEventos { get; set; }

        [MaxLength(100)]
        public string? PrimerContactoNombre { get; set; }

        [EmailAddress]
        [MaxLength(100)]
        public string? PrimerContactoEmail { get; set; }

        public Boolean PrimerContactoRecibeEmailEventos { get; set; }

        [Phone]
        [MaxLength(20)]
        public string? PrimerContactoTelefono { get; set; }

        [MaxLength(20)]
        public string? PrimerContactoParentesco { get; set; }

        [MaxLength(100)]
        public string? SegundoContactoNombre { get; set; }

        [EmailAddress]
        [MaxLength(100)]
        public string? SegundoContactoEmail { get; set; }

        public Boolean SegundoContactoRecibeEmailEventos { get; set; }

        [Phone]
        [MaxLength(20)]
        public string? SegundoContactoTelefono { get; set; }

        [MaxLength(20)]
        public string? SegundoContactoParentesco { get; set; }

        public int DepartamentoId { get; set; }

        public int CiudadId { get; set; }
    }
}