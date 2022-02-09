using Microsoft.EntityFrameworkCore;

namespace Desafio8QualiV2.Data
{
    public class WebContext : DbContext
    {
        //public DbSet<Conta> Contas { get; set; }
        //public DbSet<Despesa> Despesas { get; set; }
        //public DbSet<Receita> Receitas { get; set; }

        public WebContext(DbContextOptions<WebContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
