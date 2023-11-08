using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TelmaBolossite.Migrations
{
    /// <inheritdoc />
    public partial class terceiramigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LOGIN",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    idcliente = table.Column<string>(type: "TEXT", nullable: false),
                    emailcliente = table.Column<string>(type: "TEXT", nullable: false),
                    senhacliente = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOGIN", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PRODUTOS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    descricaoproduto = table.Column<string>(type: "TEXT", nullable: false),
                    valorproduto = table.Column<string>(type: "TEXT", nullable: false),
                    unidadeproduto = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUTOS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ITEMENCOMENDA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EncomendaId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProdutoId = table.Column<int>(type: "INTEGER", nullable: false),
                    preco = table.Column<decimal>(type: "TEXT", nullable: false),
                    quantidade = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITEMENCOMENDA", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ITEMENCOMENDA_ENCOMENDA_EncomendaId",
                        column: x => x.EncomendaId,
                        principalTable: "ENCOMENDA",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ITEMENCOMENDA_PRODUTOS_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "PRODUTOS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ITEMENCOMENDA_EncomendaId",
                table: "ITEMENCOMENDA",
                column: "EncomendaId");

            migrationBuilder.CreateIndex(
                name: "IX_ITEMENCOMENDA_ProdutoId",
                table: "ITEMENCOMENDA",
                column: "ProdutoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ITEMENCOMENDA");

            migrationBuilder.DropTable(
                name: "LOGIN");

            migrationBuilder.DropTable(
                name: "PRODUTOS");
        }
    }
}
