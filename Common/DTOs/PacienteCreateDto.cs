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
        public string SegundoNombre { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string PrimerApellido { get; set; }

        [MaxLength(50)]
        public string SegundoApellido { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }

        [Phone]
        [MaxLength(20)]
        public string Telefono { get; set; }

        [Phone]
        [MaxLength(20)]
        public string TelefonoContacto { get; set; }

        [Required]
        public DateTime FechaDiagnostico { get; set; }

        [Required]
        [MaxLength(100)]
        public string UsuarioCreacion { get; set; }

        [Required]
        [MaxLength(100)]
        public string UsuarioModificacion { get; set; }
    }

}
