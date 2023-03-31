using System.ComponentModel.DataAnnotations;

public class PacienteUpdateDto
{
    [Required]
    [MaxLength(50)]
    public string Nombre { get; set; }

    [Required]
    [MaxLength(50)]
    public string Apellido { get; set; }

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
    public string UsuarioModificacion { get; set; }
}