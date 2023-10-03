
﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aplicacaoLoja.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Display(Name = "ID")]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength (30)]
        [Display(Name ="Descrição")]
        public string descricao { get; set; }
    }
}
