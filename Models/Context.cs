using Microsoft.EntityFrameworkCore;

namespace Agencia.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Clientes> clientes { get; set; }
        public DbSet<Contato> contato { get; set; }
    }
}
