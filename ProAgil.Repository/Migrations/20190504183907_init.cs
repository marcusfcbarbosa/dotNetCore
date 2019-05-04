using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProAgil.Repository.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Eventos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Local = table.Column<string>(nullable: true),
                    DataEvento = table.Column<DateTime>(nullable: false),
                    Tema = table.Column<string>(nullable: true),
                    QtdPessoas = table.Column<int>(nullable: false),
                    ImgUrl = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eventos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Palestrantes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    MiniCurriculo = table.Column<string>(nullable: true),
                    ImgUrl = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Palestrantes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lotes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Preco = table.Column<decimal>(nullable: false),
                    DataInicio = table.Column<DateTime>(nullable: true),
                    DataFim = table.Column<DateTime>(nullable: true),
                    Quantidade = table.Column<int>(nullable: false),
                    EventoId = table.Column<int>(nullable: false),
                    EventoId1 = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lotes_Eventos_EventoId1",
                        column: x => x.EventoId1,
                        principalTable: "Eventos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PalestranteEventos",
                columns: table => new
                {
                    EventoId = table.Column<int>(nullable: false),
                    PalestranteId = table.Column<int>(nullable: false),
                    Id = table.Column<Guid>(nullable: false),
                    EventoId1 = table.Column<Guid>(nullable: true),
                    PalestranteId1 = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PalestranteEventos", x => new { x.EventoId, x.PalestranteId });
                    table.ForeignKey(
                        name: "FK_PalestranteEventos_Eventos_EventoId1",
                        column: x => x.EventoId1,
                        principalTable: "Eventos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PalestranteEventos_Palestrantes_PalestranteId1",
                        column: x => x.PalestranteId1,
                        principalTable: "Palestrantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RedeSociais",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    EventoId = table.Column<int>(nullable: true),
                    EventoId1 = table.Column<Guid>(nullable: true),
                    PalestranteId = table.Column<int>(nullable: true),
                    PalestranteId1 = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RedeSociais", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RedeSociais_Eventos_EventoId1",
                        column: x => x.EventoId1,
                        principalTable: "Eventos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RedeSociais_Palestrantes_PalestranteId1",
                        column: x => x.PalestranteId1,
                        principalTable: "Palestrantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lotes_EventoId1",
                table: "Lotes",
                column: "EventoId1");

            migrationBuilder.CreateIndex(
                name: "IX_PalestranteEventos_EventoId1",
                table: "PalestranteEventos",
                column: "EventoId1");

            migrationBuilder.CreateIndex(
                name: "IX_PalestranteEventos_PalestranteId1",
                table: "PalestranteEventos",
                column: "PalestranteId1");

            migrationBuilder.CreateIndex(
                name: "IX_RedeSociais_EventoId1",
                table: "RedeSociais",
                column: "EventoId1");

            migrationBuilder.CreateIndex(
                name: "IX_RedeSociais_PalestranteId1",
                table: "RedeSociais",
                column: "PalestranteId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lotes");

            migrationBuilder.DropTable(
                name: "PalestranteEventos");

            migrationBuilder.DropTable(
                name: "RedeSociais");

            migrationBuilder.DropTable(
                name: "Eventos");

            migrationBuilder.DropTable(
                name: "Palestrantes");
        }
    }
}
