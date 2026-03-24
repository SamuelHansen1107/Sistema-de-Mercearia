public class Usuario
{
    public string Id { get; set;}
    public string Name { get; set;}
    public string Email { get; set; }
    public string Senha{ get; set; }
    public List<Venda> Vendas { get; set; }
}