using Microsoft.EntityFrameworkCore;

public class MerceariaContext : DbContext
{
    public MerceariaContext(DbContextOptions<MerceariaContext> options) : base(options)
    {
    }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Venda> Vendas { get; set; }
    public DbSet<ItemVenda> ItensVenda { get; set; }
}