using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restoran_API.Migrations
{
    /// <inheritdoc />
    public partial class ABLoomine : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Arved",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tellimus_Id = table.Column<int>(type: "int", nullable: false),
                    Hind = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arved", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kasutajad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KasutajaNimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salasona = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Roll = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kasutajad", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Restoranid",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Laud = table.Column<int>(type: "int", nullable: false),
                    LauadeMahutavus = table.Column<int>(type: "int", nullable: false),
                    Tagid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LauaSeis = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restoranid", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tellimused",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kasutaja = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TooteNimed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kogused = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hind = table.Column<float>(type: "real", nullable: false),
                    Laud = table.Column<int>(type: "int", nullable: false),
                    Komentaar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Seisukord = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tellimused", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tooded",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hind = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tooded", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Arved");

            migrationBuilder.DropTable(
                name: "Kasutajad");

            migrationBuilder.DropTable(
                name: "Restoranid");

            migrationBuilder.DropTable(
                name: "Tellimused");

            migrationBuilder.DropTable(
                name: "Tooded");
        }
    }
}
