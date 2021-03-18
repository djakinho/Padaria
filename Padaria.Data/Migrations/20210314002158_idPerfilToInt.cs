using Microsoft.EntityFrameworkCore.Migrations;

namespace Padaria.Data.Migrations
{
    public partial class idPerfilToInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_PerfilUsuario_PerfilId",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_PerfilId",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "PerfilId",
                table: "Usuario");

            migrationBuilder.AddColumn<int>(
                name: "IdPerfil",
                table: "Usuario",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdPerfil",
                table: "Usuario");

            migrationBuilder.AddColumn<int>(
                name: "PerfilId",
                table: "Usuario",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_PerfilId",
                table: "Usuario",
                column: "PerfilId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_PerfilUsuario_PerfilId",
                table: "Usuario",
                column: "PerfilId",
                principalTable: "PerfilUsuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
