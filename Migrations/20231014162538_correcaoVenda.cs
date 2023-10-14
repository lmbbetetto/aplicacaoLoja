using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aplicacaoLoja.Migrations
{
    /// <inheritdoc />
    public partial class correcaoVenda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VendaProduto");

            migrationBuilder.RenameColumn(
                name: "vendaProdutoID",
                table: "Vendas",
                newName: "quantidade");

            migrationBuilder.AddColumn<int>(
                name: "produtoID",
                table: "Vendas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_produtoID",
                table: "Vendas",
                column: "produtoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendas_Produtos_produtoID",
                table: "Vendas",
                column: "produtoID",
                principalTable: "Produtos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendas_Produtos_produtoID",
                table: "Vendas");

            migrationBuilder.DropIndex(
                name: "IX_Vendas_produtoID",
                table: "Vendas");

            migrationBuilder.DropColumn(
                name: "produtoID",
                table: "Vendas");

            migrationBuilder.RenameColumn(
                name: "quantidade",
                table: "Vendas",
                newName: "vendaProdutoID");

            migrationBuilder.CreateTable(
                name: "VendaProduto",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    produtoID = table.Column<int>(type: "int", nullable: false),
                    quantidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendaProduto", x => x.id);
                    table.ForeignKey(
                        name: "FK_VendaProduto_Produtos_produtoID",
                        column: x => x.produtoID,
                        principalTable: "Produtos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VendaProduto_produtoID",
                table: "VendaProduto",
                column: "produtoID");
        }
    }
}
