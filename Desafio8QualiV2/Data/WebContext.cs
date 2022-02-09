using Desafio8QualiV2.Models;
using Microsoft.EntityFrameworkCore;

namespace Desafio8QualiV2.Data
{
    public class WebContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        //public DbSet<Email> Emails { get; set; }

        public WebContext(DbContextOptions<WebContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
