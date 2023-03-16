using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultasMedicas.Core.Entities
{
    public class Consulta
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public virtual ICollection<ConsultaPaciente> ConsultaPacientes { get; set; }
        public virtual ICollection<ConsultaMedico> ConsultaMedicos { get; set; }
    }
}
