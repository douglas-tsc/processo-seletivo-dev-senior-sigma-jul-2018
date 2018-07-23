using System.Data.Entity.ModelConfiguration;
using TJMT.Prova.Senior.Domain.Entities;

namespace TJMT.Prova.Senior.Infra.Data.EntityConfig
{
    public class GeneroConfig : EntityTypeConfiguration<Genero>
    {
        public GeneroConfig()
        {
            HasKey(p => p.Id);

            Property(p => p.Id).IsRequired();
        }
    }
}
