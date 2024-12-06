using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

public class AppDbContext : DbContext
{
    public DbSet<Fornecedor> Fornecedores { get; set; }
    public DbSet<Pedido> Pedidos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=banco.db");
    }
}