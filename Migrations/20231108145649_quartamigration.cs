using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TelmaBolossite.Migrations
{
    /// <inheritdoc />
    public partial class quartamigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "PRODUTOS",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CATEGORIAS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CATEGORIAS", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PRODUTOS_CategoriaId",
                table: "PRODUTOS",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_PRODUTOS_CATEGORIAS_CategoriaId",
                table: "PRODUTOS",
                column: "CategoriaId",
                principalTable: "CATEGORIAS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PRODUTOS_CATEGORIAS_CategoriaId",
                table: "PRODUTOS");

            migrationBuilder.DropTable(
                name: "CATEGORIAS");

            migrationBuilder.DropIndex(
                name: "IX_PRODUTOS_CategoriaId",
                table: "PRODUTOS");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "PRODUTOS");
        }
    }
}
