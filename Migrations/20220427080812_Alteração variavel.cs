using Microsoft.EntityFrameworkCore.Migrations;

namespace GestaoEscolar.Migrations
{
    public partial class Alteraçãovariavel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Percentil",
                table: "Alunos");

            migrationBuilder.AddColumn<string>(
                name: "PesoIdade",
                table: "Alunos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PesoIdade",
                table: "Alunos");

            migrationBuilder.AddColumn<string>(
                name: "Percentil",
                table: "Alunos",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
