using Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Infra.Configuracao
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Produto> Produto { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(GetStringConectionString());

            base.OnConfiguring(optionsBuilder);
        }
        private string GetStringConectionString()
        {
            string strCon = "Data Source=SPBOX\\SQLEXPRESS;Initial Catalog=ProjetoModeloDDD; Integrated Security=True";
            return strCon;
        }

    }
}
