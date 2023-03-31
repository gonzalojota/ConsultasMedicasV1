namespace ConsultasMedicas.Core.Entities
{
    public class Medico
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Especialidad { get; set; }
        public virtual ICollection<ConsultaMedico> ConsultaMedicos { get; set; }
    }
}
