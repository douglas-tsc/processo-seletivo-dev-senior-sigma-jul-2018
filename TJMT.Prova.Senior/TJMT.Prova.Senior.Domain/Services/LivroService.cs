using System.Collections.Generic;
using System.Linq;
using TJMT.Prova.Senior.Domain.Entities;
using TJMT.Prova.Senior.Domain.Interfaces.Repositories;
using TJMT.Prova.Senior.Domain.Interfaces.Services;

namespace TJMT.Prova.Senior.Domain.Services
{
    public class LivroService : ServiceBase<Livro>, ILivroService
    {
        private readonly ILivroRepository _livroRepository;

        public LivroService(ILivroRepository livroRepository) : base(livroRepository)
        {
            _livroRepository = livroRepository;
        }

    }
}
