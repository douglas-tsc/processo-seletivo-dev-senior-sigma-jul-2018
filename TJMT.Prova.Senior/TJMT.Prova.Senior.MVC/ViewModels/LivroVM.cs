using System;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace TJMT.Prova.Senior.MVC.ViewModels
{
    public class LivroVM
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Preencha o Titulo")]
        public string Titulo { get; set; }
        [Required(ErrorMessage ="Preencha o Número de paginas")]
        public int Paginas { get; set; }
        [Required(ErrorMessage ="Preencha a Descrição")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Preencha a Sinopse")]
        public string Sinopse { get; set; }

        public GeneroVM Generos { get; set; }

        [Required(ErrorMessage ="Informe Data Publicação")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime DataPublicacao { get; set; }

        //public Autor Autor { get; set; }

        //public Editora Editora { get; set; }
        [Required(ErrorMessage = "Carregue uma Capa")]
        [DataType(DataType.Upload)]
        public  HttpPostedFileBase Capa { get; set; }

        public byte[] CapaExibicao { get; set; }
    }
}