using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aplicacaoLoja.Models
{
    [Table("Fornecedores")]
    public class Fornecedor
    {
        [Key]
        public int id { get; set; }

        
        [StringLength(35)]
        public char nome { get; set; }

        
        public char telefone { get; set; }

        [StringLength(50)]
        public char endereco { get; set; }

      
        public char cnpj { get; set; }

    }
}
