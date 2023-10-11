using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aplicacaoLoja.Migrations
{
    /// <inheritdoc />
    public partial class venda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Vendas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    total = table.Column<double>(type: "float", nullable: false),
                    clienteID = table.Column<int>(type: "int", nullable: false),
                    funcionarioID = table.Column<int>(type: "int", nullable: false),
                    vendaProdutoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendas", x => x.id);
                    table.ForeignKey(
                        name: "FK_Vendas_Clientes_clienteID",
                        column: x => x.clienteID,
                        principalTable: "Clientes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vendas_Funcionarios_funcionarioID",
                        column: x => x.funcionarioID,
                        principalTable: "Funcionarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VendaProduto_produtoID",
                table: "VendaProduto",
                column: "produtoID");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_clienteID",
                table: "Vendas",
                column: "clienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_funcionarioID",
                table: "Vendas",
                column: "funcionarioID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VendaProduto");

            migrationBuilder.DropTable(
                name: "Vendas");
        }
    }
}
