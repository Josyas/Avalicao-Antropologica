using GestaoEscolar.Models;
using Microsoft.EntityFrameworkCore;
namespace GestaoEscolar
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data source=DESKTOP-DK1QHG7\SQLEXPRESS; Integrated security=SSPI;initial Catalog=GestaoEscolar");
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Escola> Escolas { get; set; }
    }
}
