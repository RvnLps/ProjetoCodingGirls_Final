using Microsoft.EntityFrameworkCore;

namespace ProjetoCodingGirls_Escola.Models
{
    public class EscolaContext : DbContext
    {
        //comando padrão
        public EscolaContext(DbContextOptions<EscolaContext> options) : base(options)
        { }

        // podemos gerenciar a partir daqui, vazemos o vinculo de classe com banco de dados
        public DbSet<Turma> Turma { get; set; }
        public DbSet<Aluno> Aluno { get; set; }
      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Turma>().ToTable("Turma");


            modelBuilder.Entity<Turma>();
                // .HasMany(e => e.Aluno)
                // .WithOne(e => e.Turma);
               
            modelBuilder.Entity<Aluno>().ToTable("Aluno");

            modelBuilder.Entity<Aluno>()
                .HasOne(e => e.Turma)
                .WithMany(e => e.Aluno)
                .HasForeignKey(e => e.Id_Turma);

        }


    }
}
