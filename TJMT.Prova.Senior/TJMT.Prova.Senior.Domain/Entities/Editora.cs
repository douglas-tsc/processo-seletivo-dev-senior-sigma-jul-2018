using System.Collections.Generic;

namespace TJMT.Prova.Senior.Domain.Entities
{
    public class Editora
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Inscricao { get; set; }

        public IEnumerable<Livro> Livros { get; set; }
    }
}