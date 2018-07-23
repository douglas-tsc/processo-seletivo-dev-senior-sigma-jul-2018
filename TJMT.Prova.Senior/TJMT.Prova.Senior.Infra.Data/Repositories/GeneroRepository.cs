using System.Collections.Generic;
using System.Linq;
using TJMT.Prova.Senior.Domain.Entities;
using TJMT.Prova.Senior.Domain.Interfaces.Repositories;

namespace TJMT.Prova.Senior.Infra.Data.Repositories
{
    public class GeneroRepository : RepositoryBase<Genero>, IGeneroRepository
    {
        public IEnumerable<Genero> BuscarPorGenero(string genero)
        {
            return Db.Generos.Where(g => g.Nome == genero);
        }
    }
}
