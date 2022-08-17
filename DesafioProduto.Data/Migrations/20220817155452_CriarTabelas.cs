using Microsoft.EntityFrameworkCore.Migrations;

namespace DesafioProduto.Data.Migrations
{
    public partial class CriarTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_Produto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Preco = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Produto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_ItemEstoque",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Qtde = table.Column<int>(type: "int", nullable: false),
                    Id_Produto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_ItemEstoque", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_ItemEstoque_tb_Produto_Id_Produto",
                        column: x => x.Id_Produto,
                        principalTable: "tb_Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Loja",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_ItemEstoque = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Loja", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_Loja_tb_ItemEstoque_Id_ItemEstoque",
                        column: x => x.Id_ItemEstoque,
                        principalTable: "tb_ItemEstoque",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_ItemEstoque_Id_Produto",
                table: "tb_ItemEstoque",
                column: "Id_Produto");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Loja_Id_ItemEstoque",
                table: "tb_Loja",
                column: "Id_ItemEstoque");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_Loja");

            migrationBuilder.DropTable(
                name: "tb_ItemEstoque");

            migrationBuilder.DropTable(
                name: "tb_Produto");
        }
    }
}
