using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aplicacaoLoja.Models
{
    [Table("Fornecedores")]
    public class Fornecedor
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(40)]
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(12)]
        [Display(Name = "Telefone")]
        public string telefone { get; set; }

        [Display(Name = "Endereco")]
        [StringLength(80)]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string endereco { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(14)]
        [Display(Name = "Cnpj")]
        public string cnpj { get; set; }

    }
}
