using Microsoft.EntityFrameworkCore;
using VidaEMinsterio.Models;

namespace VidaEMinsterio.Data
{
    public class SistemaTarefasDBContext : DbContext
    {
        public SistemaTarefasDBContext(DbContextOptions<SistemaTarefasDBContext> options)
            : base(options)
        {

        }

        public DbSet<ParticipanteModel> Participantes { get; set; }
        public DbSet<DesignacaoModel>   Designacoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
