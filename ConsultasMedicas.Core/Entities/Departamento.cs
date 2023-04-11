namespace ConsultasMedicas.Core.Entities
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public virtual ICollection<Ciudad> Ciudades { get; set; }
    }
}
