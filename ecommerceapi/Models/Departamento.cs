namespace ecommerceapi.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public List<Usuario> Usuarios { get; set; }
    }
}
