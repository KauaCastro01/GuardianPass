using GuardianPass.Model;
using Microsoft.EntityFrameworkCore;

namespace GuardianPass.Data
{
    public class AppDbContext : DbContext
    {
        private readonly string _db;
        public AppDbContext(string db)
        {
            _db = db;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={_db}");

        public DbSet<UsuariosModel> Usuario { get; set;}
        public DbSet<AplicativosModel> Aplicativo { get; set; }
        public DbSet<LogErroModel> LogErro { get; set; }
    }
}