using Microsoft.EntityFrameworkCore.Migrations;

namespace Padaria.Data.Migrations
{
    public partial class Aftermerge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MateriaPrimaProduto",
                columns: table => new
                {
                    IdMateriaPrima = table.Column<int>(nullable: false),
                    IdProduto = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MateriaPrimaProduto", x => new { x.IdMateriaPrima, x.IdProduto });
                    table.ForeignKey(
                        name: "FK_MateriaPrimaProduto_MateriaPrima_IdMateriaPrima",
                        column: x => x.IdMateriaPrima,
                        principalTable: "MateriaPrima",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MateriaPrimaProduto_Produto_IdProduto",
                        column: x => x.IdProduto,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MateriaPrimaProduto_IdProduto",
                table: "MateriaPrimaProduto",
                column: "IdProduto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MateriaPrimaProduto");
        }
    }
}
