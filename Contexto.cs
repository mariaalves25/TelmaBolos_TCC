using Microsoft.EntityFrameworkCore;
using TelmaBolossite.Entidades;

namespace TelmaBolossite
{
    public class Contexto : DbContext
    {
        public Contexto (DbContextOptions<Contexto> opt) : base(opt) { }
        
        public DbSet<Cliente> CLIENTES { get; set; }
        public DbSet<Encomenda> ENCOMENDA { get; set; }
        public DbSet<Itemencomenda> ITEMENCOMENDA { get; set; }
        public DbSet<Produto> PRODUTOS { get; set; }
        public DbSet<Login> LOGIN  { get; set; }
        public DbSet<Categoria> CATEGORIAS { get; set; }
    }
}
