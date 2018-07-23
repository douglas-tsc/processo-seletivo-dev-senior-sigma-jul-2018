using System.Collections.Generic;

namespace TJMT.Prova.Senior.Domain.Entities
{
    public class Autor
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public IEnumerable<Livro> Livros {get;set;}

    }
}