using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultasMedicas.Core.Entities
{
    public class ConsultaPaciente
    {
        public int ConsultaId { get; set; }
        public virtual Consulta Consulta { get; set; }
        public int PacienteId { get; set; }
        public virtual Paciente Paciente { get; set; }
    }

}
