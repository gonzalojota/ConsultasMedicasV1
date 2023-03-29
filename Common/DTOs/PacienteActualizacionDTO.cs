using System.ComponentModel.DataAnnotations;

public class PacienteActualizacionDTO
{
    [Required]
    public string Nombre { get; set; }
    [Required]
    public string Apellido { get; set; }
    [Required]
    public DateTime FechaNacimiento { get; set; }
    public string Email { get; set; }

    public string Telefono { get; set; }
}