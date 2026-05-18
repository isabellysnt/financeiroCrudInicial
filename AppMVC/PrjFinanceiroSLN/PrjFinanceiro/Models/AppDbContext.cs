
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PrjFinanceiro.Models

{
    
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Agencia> Agencia { get; set; }
        public DbSet<cargo> Cargo { get; set; }
        public DbSet<TipoConta> TipoConta { get; set; }

    }
}
