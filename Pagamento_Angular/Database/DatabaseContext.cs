using Microsoft.EntityFrameworkCore;
using Pagamento_Angular.Models;

namespace Pagamento_Angular.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //   optionsBuilder.UseSqlServer("DevConnection");
        //}
        public DbSet<PagamentoDetail> PagamentoDetails { get; set; }
    }
}
