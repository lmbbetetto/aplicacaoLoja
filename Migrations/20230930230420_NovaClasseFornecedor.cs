using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aplicacaoLoja.Migrations
{
    /// <inheritdoc />
    public partial class NovaClasseFornecedor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fornecedores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(35)", maxLength: 35),
                    telefone = table.Column<string>(type: "nvarchar()"),
                    endereco = table.Column<string>(type: "nvarchar(50)", maxLength: 50),
                    cnpj = table.Column<string>(type: "nvarchar(30)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedores", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fornecedores");
        }
    }
}
