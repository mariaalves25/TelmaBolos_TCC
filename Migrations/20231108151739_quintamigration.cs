using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TelmaBolossite.Migrations
{
    /// <inheritdoc />
    public partial class quintamigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "imagem",
                table: "PRODUTOS",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imagem",
                table: "PRODUTOS");
        }
    }
}
