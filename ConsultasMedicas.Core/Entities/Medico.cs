using System.ComponentModel.DataAnnotations;

namespace ConsultasMedicas.Core.Entities
{
    public class Medico
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(50)]
        public string Apellido { get; set; }

        public int MedicoEspcialidadId { get; set; }
        public MedicoEspecialidad? Especialidad { get; set; }
        public virtual ICollection<ConsultaMedico> ConsultaMedicos { get; set; }
    }
}
