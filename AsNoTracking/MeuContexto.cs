using Microsoft.EntityFrameworkCore;

namespace AsNoTracking
{
    public class MeuContexto : DbContext
    {
        public MeuContexto(DbContextOptions<MeuContexto> options) : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
