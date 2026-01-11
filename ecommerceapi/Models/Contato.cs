namespace ecommerceapi.Models
{
    public class Contato
    {
        public int Id { get; set; }
        public int CodigoUsuario { get; set; }
        public string Telefone { get; set; } = string.Empty;
        public string Celular { get; set; } = string.Empty;
    }
}
