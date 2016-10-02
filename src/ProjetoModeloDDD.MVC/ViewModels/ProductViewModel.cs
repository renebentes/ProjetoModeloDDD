using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class ProductViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(250, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Preencha o campo Valor")]
        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "999999999999")]
        public decimal Price { get; set; }

        [DisplayName("Disponível")]
        public bool Available { get; set; }

        public int CustomerId { get; set; }

        public virtual CustomerViewModel Customer { get; set; }
    }
}