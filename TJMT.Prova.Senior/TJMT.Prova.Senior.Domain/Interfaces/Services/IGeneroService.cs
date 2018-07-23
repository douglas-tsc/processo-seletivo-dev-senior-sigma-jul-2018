using System.Collections.Generic;
using TJMT.Prova.Senior.Domain.Entities;

namespace TJMT.Prova.Senior.Domain.Interfaces.Services
{
    public interface IGeneroService : IServiceBase<Genero>
    {
        IEnumerable<Genero> BuscarPorGenero(string genero);
    }
}
