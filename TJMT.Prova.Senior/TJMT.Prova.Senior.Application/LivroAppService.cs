using TJMT.Prova.Senior.Application.Interface;
using TJMT.Prova.Senior.Domain.Entities;
using TJMT.Prova.Senior.Domain.Interfaces.Services;

namespace TJMT.Prova.Senior.Application
{
    public class LivroAppService : AppServiceBase<Livro>, ILivroAppService
    {
        private readonly ILivroService _livroService;

        public LivroAppService(ILivroService livroService) : base(livroService)
        {
            _livroService = livroService;
        }
    }
}
