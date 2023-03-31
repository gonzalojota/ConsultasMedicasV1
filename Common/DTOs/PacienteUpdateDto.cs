using System.ComponentModel.DataAnnotations;

public class PacienteUpdateDto
{
    [Required]
    [MaxLength(50)]
    public string PrimerNombre { get; set; }

    [Required]
    [MaxLength(50)]
    public string PrimerApellido { get; set; }

    [MaxLength(50)]
    public string SegundoNombre { get; set; }

    [MaxLength(50)]
    public string SegundoApellido { get; set; }

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