using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultasMedicas.Core.Entities
{
    public class Paciente
{
    public int Id { get; set; }
    
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

    public DateTime FechaCreacion { get; set; }
    public DateTime FechaModificacion { get; set; }
    public string UsuarioCreacion { get; set; }
    public string UsuarioModificacion { get; set; }

    public DateTime FechaDiagnostico { get; set; }

     public virtual ICollection<ConsultaPaciente> ConsultaPacientes { get; set; }
    public virtual ICollection<Notificacion> Notificaciones { get; set; }
}
}
