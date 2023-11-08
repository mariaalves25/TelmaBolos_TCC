﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TelmaBolossite.Migrations
{
    /// <inheritdoc />
    public partial class segundamigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ENCOMENDA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: false),
                    dataencomenda = table.Column<DateTime>(type: "TEXT", nullable: false),
                    dataretirada = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ENCOMENDA", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ENCOMENDA_CLIENTES_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "CLIENTES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ENCOMENDA_ClienteId",
                table: "ENCOMENDA",
                column: "ClienteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ENCOMENDA");
        }
    }
}
