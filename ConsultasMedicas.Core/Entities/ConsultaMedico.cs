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
