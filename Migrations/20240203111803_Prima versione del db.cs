using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace zamagni.davide._5i.Migrations
{
    /// <inheritdoc />
    public partial class Primaversionedeldb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prenotaziones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Cognome = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Sesso = table.Column<string>(type: "TEXT", nullable: true),
                    DataNascita = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Ruolo = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prenotaziones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prodottis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Quantità = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prodottis", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prenotaziones");

            migrationBuilder.DropTable(
                name: "Prodottis");
        }
    }
}
