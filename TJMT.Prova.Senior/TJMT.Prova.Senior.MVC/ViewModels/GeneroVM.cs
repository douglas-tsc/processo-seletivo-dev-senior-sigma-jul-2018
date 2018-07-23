using System.ComponentModel.DataAnnotations;

namespace TJMT.Prova.Senior.MVC.ViewModels
{
    public class GeneroVM
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage="Informe o Nome do Genero")]
        public string Nome { get; set; }

    }
}