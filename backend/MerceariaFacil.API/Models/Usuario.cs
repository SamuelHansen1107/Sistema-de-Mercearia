public class Usuario
{
    public int Id { get; set;}
    public string? Name { get; set;}
    public string? Email { get; set; }
    public string? Senha{ get; set; }
    public List<Venda> Vendas { get; set; } = new ();
}