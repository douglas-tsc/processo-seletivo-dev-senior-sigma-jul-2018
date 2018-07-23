using TJMT.Prova.Senior.Application.Interface;
using TJMT.Prova.Senior.Domain.Entities;
using TJMT.Prova.Senior.Domain.Interfaces.Services;

namespace TJMT.Prova.Senior.Application
{
    public class GeneroAppService : AppServiceBase<Genero>, IGeneroAppService
    {
        private readonly IGeneroService _generoService;

        public GeneroAppService(IGeneroService generoService) : base(generoService)
        {
            _generoService = generoService;
        }
    }
}
