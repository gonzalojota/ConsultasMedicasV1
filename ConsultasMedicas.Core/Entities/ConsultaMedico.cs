using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultasMedicas.Core.Entities
{
    public class ConsultaMedico
    {
        public int ConsultaId { get; set; }
        public virtual Consulta Consulta { get; set; }
        public int MedicoId { get; set; }
        public virtual Medico Medico { get; set; }
    }
}
