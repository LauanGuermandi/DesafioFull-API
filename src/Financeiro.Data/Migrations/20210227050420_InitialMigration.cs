using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: true),
                    DataAtualizacao = table.Column<DateTime>(nullable: false),
                    Nome = table.Column<string>(maxLength: 255, nullable: false),
                    CPF = table.Column<string>(maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Divida",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: true),
                    DataAtualizacao = table.Column<DateTime>(nullable: false),
                    ValorOriginal = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    NumeroTitulo = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    PorcentagemJuros = table.Column<int>(nullable: false),
                    PorcentagemMulta = table.Column<int>(nullable: false),
                    PessoaId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divida", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Divida_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Parcela",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: true),
                    DataAtualizacao = table.Column<DateTime>(nullable: false),
                    Numero = table.Column<int>(nullable: false),
                    DataVencimento = table.Column<DateTime>(type: "datetime", nullable: false),
                    Valor = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    DividaId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parcela", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parcela_Divida_DividaId",
                        column: x => x.DividaId,
                        principalTable: "Divida",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Divida_PessoaId",
                table: "Divida",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Parcela_DividaId",
                table: "Parcela",
                column: "DividaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_CPF",
                table: "Pessoa",
                column: "CPF",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parcela");

            migrationBuilder.DropTable(
                name: "Divida");

            migrationBuilder.DropTable(
                name: "Pessoa");
        }
    }
}
