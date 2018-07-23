using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using TJMT.Prova.Senior.Domain.Entities;

namespace TJMT.Prova.Senior.Infra.Data.Context
{
    public class ProvaSeniorContext : DbContext
    {

        public ProvaSeniorContext(): base("ProvaSenior")
        {

        }

        public DbSet<Livro> Livros { get; set; }

        public DbSet<Editora> Editoras { get; set; }

        public DbSet<Autor>  Autores { get; set; }

        public DbSet<Genero> Generos { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties().Where(x => x.Name == x.ReflectedType.Name + "Id").Configure(x => x.IsKey());
            base.OnModelCreating(modelBuilder);
        }

    }
}
