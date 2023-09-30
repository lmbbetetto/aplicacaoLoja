using Microsoft.EntityFrameworkCore;

namespace aplicacaoLoja.Models
{
    public class Contexto : DbContext
    {
        
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
        public DbSet<Fornecedor> Fornecedores { get; set; }
    }

}
