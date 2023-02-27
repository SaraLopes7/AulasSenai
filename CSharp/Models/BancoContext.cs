using Microsoft.EntityFrameworkCore;

namespace LH_Pets.Models
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<Banco> Bancos { get; set; }
    }
}
