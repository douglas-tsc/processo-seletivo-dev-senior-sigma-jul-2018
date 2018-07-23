using System;

namespace TJMT.Prova.Senior.Domain.Entities
{
    public class Livro
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public int Paginas { get; set; }

        public string Descricao { get; set; }

        public string Sinopse { get; set; }

        public Genero Generos { get; set; }

        public DateTime DataPublicacao { get; set; }

        public Autor Autor { get; set; }

        public Editora Editora { get; set; }

        public  Byte[] Capa { get; set; }


    }
}
