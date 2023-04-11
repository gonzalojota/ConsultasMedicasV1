using System.ComponentModel.DataAnnotations;

namespace ConsultasMedicas.Common.DTOs
{
    public class MedicoCreateDTO
    {
        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(50)]
        public string Apellido { get; set; }

        [Required]
        public int? MedicoEspecialidadId { get; set; }
    }

}
