using System.Collections.Generic;
using TJMT.Prova.Senior.Domain.Entities;
using TJMT.Prova.Senior.Domain.Interfaces.Repositories;
using TJMT.Prova.Senior.Domain.Interfaces.Services;

namespace TJMT.Prova.Senior.Domain.Services
{
    public class GeneroService : ServiceBase<Genero>, IGeneroService
    {
        private readonly IGeneroRepository _generoRepository;

        public GeneroService(IGeneroRepository repository) : base(repository)
        {
            _generoRepository = repository;
        }

        public IEnumerable<Genero> BuscarPorGenero(string genero)
        {
            return _generoRepository.BuscarPorGenero(genero);
        }
    }
}
