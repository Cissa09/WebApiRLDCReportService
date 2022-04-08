using Microsoft.EntityFrameworkCore;

namespace ReportService
{
    public class AppDbConnection : DbContext
    {       
        public AppDbConnection(DbContextOptions<AppDbConnection> options) : base(options) { }

        public DbSet<ProdutoModel> produtoModel { get; set; }
        public string ConnectionString { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
