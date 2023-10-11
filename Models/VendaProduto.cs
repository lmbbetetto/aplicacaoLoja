using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aplicacaoLoja.Models
{
    public class VendaProduto
    {
        public int id { get; set; }

        public int produtoID { get; set; }
        [ForeignKey("produtoID")]
        public Produto produto { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public int quantidade { get; set; }
    }
}
