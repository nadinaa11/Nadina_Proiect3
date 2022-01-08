using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nadina_Proiect3.Migrations
{
    public partial class categorie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorie",
                columns: table => new
                {
                    CategorieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Denumire = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorie", x => x.CategorieId);
                });

            migrationBuilder.CreateTable(
                name: "CategorieProdus",
                columns: table => new
                {
                    CategorieProdusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdusId = table.Column<int>(type: "int", nullable: false),
                    CategorieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategorieProdus", x => x.CategorieProdusId);
                    table.ForeignKey(
                        name: "FK_CategorieProdus_Categorie_CategorieId",
                        column: x => x.CategorieId,
                        principalTable: "Categorie",
                        principalColumn: "CategorieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategorieProdus_Produs_ProdusId",
                        column: x => x.ProdusId,
                        principalTable: "Produs",
                        principalColumn: "ProdusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategorieProdus_CategorieId",
                table: "CategorieProdus",
                column: "CategorieId");

            migrationBuilder.CreateIndex(
                name: "IX_CategorieProdus_ProdusId",
                table: "CategorieProdus",
                column: "ProdusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategorieProdus");

            migrationBuilder.DropTable(
                name: "Categorie");
        }
    }
}
