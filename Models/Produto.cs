using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aplicacaoLoja.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Display(Name = "ID")]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(50)]
        [Display(Name = "Descrição")]
        public string descricao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Preço")]
        public decimal preco { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Qtde Estoque")]
        public int qtdeEstoque { get; set; }

        public int categoriaID { get; set; }
        [ForeignKey("categoriaID")]
        [Display(Name = "Categoria")]
        public Categoria categoria { get; set; }

        public int fornecedorID { get; set; }
        [ForeignKey("fornecedorID")]
        [Display(Name = "Fornecedor")]
        public Fornecedor fornecedor { get; set; }
    }
}
