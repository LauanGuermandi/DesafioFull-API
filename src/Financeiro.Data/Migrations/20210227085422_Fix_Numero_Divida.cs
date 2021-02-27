using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Fix_Numero_Divida : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Divida_NumeroTitulo",
                table: "Divida",
                column: "NumeroTitulo",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Divida_NumeroTitulo",
                table: "Divida");
        }
    }
}
