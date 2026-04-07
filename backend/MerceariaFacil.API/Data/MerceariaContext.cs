using Microsoft.EntityFrameworkCore;

public class MerceariaContext : DbContext
{
    private string stringConexao = "Server=localhost;Port=3306;Database=MerceariaDB;Uid=root;Pwd=123;";
    public MerceariaContext()
    {
    }
    public MerceariaContext(DbContextOptions<MerceariaContext> options) : base(options)
    {
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    if (!optionsBuilder.IsConfigured)
    {
        optionsBuilder.UseMySql(stringConexao, ServerVersion.AutoDetect(stringConexao));
    }
}

    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Venda> Vendas { get; set; }
    public DbSet<ItemVenda> ItensVenda { get; set; }
}