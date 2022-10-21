using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fiap.Aula05.Web.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Corretoras",
                columns: table => new
                {
                    CorretoraId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Corretoras", x => x.CorretoraId);
                });

            migrationBuilder.CreateTable(
                name: "Objetivos",
                columns: table => new
                {
                    ObjetivoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objetivos", x => x.ObjetivoId);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    StatusInvestimentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.StatusInvestimentoId);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Investimento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Rendimento = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CapitalInvestido = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TipoInvestimento = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatusInvestimentoId = table.Column<int>(type: "int", nullable: false),
                    CorretoraId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Investimento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_Investimento_Corretoras_CorretoraId",
                        column: x => x.CorretoraId,
                        principalTable: "Corretoras",
                        principalColumn: "CorretoraId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tbl_Investimento_Status_StatusInvestimentoId",
                        column: x => x.StatusInvestimentoId,
                        principalTable: "Status",
                        principalColumn: "StatusInvestimentoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InvestimentosObjetivos",
                columns: table => new
                {
                    ObjetivoId = table.Column<int>(type: "int", nullable: false),
                    InvestimentoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvestimentosObjetivos", x => new { x.ObjetivoId, x.InvestimentoId });
                    table.ForeignKey(
                        name: "FK_InvestimentosObjetivos_Objetivos_ObjetivoId",
                        column: x => x.ObjetivoId,
                        principalTable: "Objetivos",
                        principalColumn: "ObjetivoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvestimentosObjetivos_Tbl_Investimento_InvestimentoId",
                        column: x => x.InvestimentoId,
                        principalTable: "Tbl_Investimento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InvestimentosObjetivos_InvestimentoId",
                table: "InvestimentosObjetivos",
                column: "InvestimentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Investimento_CorretoraId",
                table: "Tbl_Investimento",
                column: "CorretoraId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Investimento_StatusInvestimentoId",
                table: "Tbl_Investimento",
                column: "StatusInvestimentoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InvestimentosObjetivos");

            migrationBuilder.DropTable(
                name: "Objetivos");

            migrationBuilder.DropTable(
                name: "Tbl_Investimento");

            migrationBuilder.DropTable(
                name: "Corretoras");

            migrationBuilder.DropTable(
                name: "Status");
        }
    }
}
