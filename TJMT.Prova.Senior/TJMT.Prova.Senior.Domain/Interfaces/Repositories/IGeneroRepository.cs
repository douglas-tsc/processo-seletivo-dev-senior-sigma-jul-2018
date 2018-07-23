using System.Collections.Generic;
using TJMT.Prova.Senior.Domain.Entities;

namespace TJMT.Prova.Senior.Domain.Interfaces.Repositories
{
    public interface IGeneroRepository : IRepositoryBase<Genero>
    {
        IEnumerable<Genero> BuscarPorGenero(string genero);
    }
}
