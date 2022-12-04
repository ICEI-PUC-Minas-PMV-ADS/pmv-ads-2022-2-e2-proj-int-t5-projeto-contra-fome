using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_mySQL.Migrations
{
    public partial class Doacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doacao",
                columns: table => new
                {
                    idDoacao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    tipoDoacao = table.Column<int>(type: "int", nullable: true),
                    Valor = table.Column<int>(type: "int", nullable: true),
                    idCampanha = table.Column<int>(type: "int", nullable: false),
                    CadastroCampanhaidCampanha = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doacao", x => x.idDoacao);
                    table.ForeignKey(
                        name: "FK_Doacao_cadastroCampanha_CadastroCampanhaidCampanha",
                        column: x => x.CadastroCampanhaidCampanha,
                        principalTable: "cadastroCampanha",
                        principalColumn: "idCampanha");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Doacao_CadastroCampanhaidCampanha",
                table: "Doacao",
                column: "CadastroCampanhaidCampanha");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doacao");
        }
    }
}
