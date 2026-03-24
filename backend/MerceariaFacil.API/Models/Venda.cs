public class Venda
{
    public int Id { get; set; }
    public int UsuarioId { get; set; }
    public decimal ValorTotal { get; set; }
    public DateTime Data { get; set; }

    public Usuario Usuario { get; set; }
    public List<ItemVenda> ItensVenda { get; set; }
}