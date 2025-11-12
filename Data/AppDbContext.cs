using Microsoft.EntityFrameworkCore;
using SISTEMA_DE_CURSOS_MVC.Models;
//local de configurações do banco de dados


namespace SISTEMA_DE_CURSOS_MVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)  //recebendo as opções de configuração do banco
        {

        }


        //direciona a classe curso para a tabela curso no banco de dados, mas ainda não foi criada
        public DbSet<Curso> TabelaCurso { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Curso>()
           .HasDiscriminator<string>("Tipo")
           .HasValue<Tecnico>("Tecnico")
           .HasValue<Superior>("Superior");
        }

    }
}

//da erros porque nao baixamos as bibliotecas as 3 primeiras