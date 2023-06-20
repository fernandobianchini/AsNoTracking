using BenchmarkDotNet.Attributes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AsNoTracking
{
    [MemoryDiagnoser]
    public class Benchmark
    {
        private DbContextOptions<MeuContexto> _options;
        private MeuContexto _context;

        [GlobalSetup]
        public void Setup()
        {
            IConfiguration config = new ConfigurationBuilder()
                                        .AddJsonFile("appsettings.json")
                                        .AddEnvironmentVariables()
                                        .Build();
            
            _options = new DbContextOptionsBuilder<MeuContexto>()
                .UseSqlServer(config.GetConnectionString("DefaultConnection"))
                .Options;

            _context = new MeuContexto(_options);
            _context.Database.EnsureCreated();
         
            // Popula o banco de dados com dados de exemplo
            for (int i = 1; i <= 10000; i++)
            {
                _context.Produtos.Add(new Produto { Nome = $"Produto {i}" });
            }
            _context.SaveChanges();
        }

        [GlobalCleanup]
        public void Cleanup()
        {
            _context.Database.EnsureDeleted();
            _context.Dispose();
        }

        [Benchmark]
        public void ConsultaComRastreamento()
        {
            using var context = new MeuContexto(_options);
            var produtos = context.Produtos.ToList();
        }

        [Benchmark]
        public void ConsultaSemRastreamento()
        {
            using var context = new MeuContexto(_options);
            var produtos = context.Produtos.AsNoTracking().ToList();
        }
    }
}
