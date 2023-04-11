namespace ConsultasMedicas.Core.Entities
{
    public class Ciudad
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public int DepartamentoId { get; set; }
        public virtual Departamento Departamento { get; set; }

    }

}
