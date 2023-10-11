using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace aplicacaoLoja.Models
{
    [Table("Vendas")]
    public class Venda
    {
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Data")]
        [DataType(DataType.DateTime)]
        public DateTime data { get; set; }

        [Display(Name = "Total")]
        public decimal total { get; set; }

        public int clienteID { get; set; }
        [ForeignKey("clienteID")]
        [Display(Name = "Cliente")]
        public Cliente cliente { get; set; }

        public int funcionarioID { get; set; }
        [ForeignKey("funcionarioID")]
        [Display(Name = "Funcionário")]
        public Funcionario funcionario { get; set; }

        public int vendaProdutoID { get; set; }
        [ForeignKey("vendaProdutoID")]
        [Display(Name = "Lista de produtos")]
        List<VendaProduto> listaProdutos { get; set; }

        public decimal CalcularTotal()
        {
            decimal total = 0;
            foreach(var vendaProduto in listaProdutos)
            {
                total += vendaProduto.quantidade * vendaProduto.produto.preco;
            }
            return total;
        }
    }
}
