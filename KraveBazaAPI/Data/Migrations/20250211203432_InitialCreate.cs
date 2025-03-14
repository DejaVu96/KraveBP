using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KraveBazaAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Krave",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RedniBroj = table.Column<int>(type: "INTEGER", nullable: false),
                    DatumRodjenja = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ImeMajke = table.Column<string>(type: "TEXT", nullable: true),
                    Vakcina3Dana = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Vakcina10Dana = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DatumOsemenjavanja = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Provera = table.Column<DateTime>(type: "TEXT", nullable: true),
                    SteonostPregled = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Zasusivanje = table.Column<DateTime>(type: "TEXT", nullable: true),
                    TeljenjeTermin = table.Column<DateTime>(type: "TEXT", nullable: true),
                    TeljenjeDatum = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Injekcija = table.Column<DateTime>(type: "TEXT", nullable: true),
                    MoguceOsemenjavanje = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Krave", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Krave");
        }
    }
}
