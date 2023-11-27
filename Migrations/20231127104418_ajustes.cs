using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TelmaBolossite.Migrations
{
    /// <inheritdoc />
    public partial class ajustes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "senhacliente",
                table: "CLIENTES",
                newName: "Sobrenome");

            migrationBuilder.RenameColumn(
                name: "nomecliente",
                table: "CLIENTES",
                newName: "Senha");

            migrationBuilder.RenameColumn(
                name: "emailcliente",
                table: "CLIENTES",
                newName: "Nome");

            migrationBuilder.AddColumn<string>(
                name: "Confirmarsenha",
                table: "CLIENTES",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "CLIENTES",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Confirmarsenha",
                table: "CLIENTES");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "CLIENTES");

            migrationBuilder.RenameColumn(
                name: "Sobrenome",
                table: "CLIENTES",
                newName: "senhacliente");

            migrationBuilder.RenameColumn(
                name: "Senha",
                table: "CLIENTES",
                newName: "nomecliente");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "CLIENTES",
                newName: "emailcliente");
        }
    }
}
