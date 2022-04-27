using Microsoft.EntityFrameworkCore.Migrations;

namespace GestaoEscolar.Migrations
{
    public partial class AddImcEPercentil : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Imc",
                table: "Alunos",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Percentil",
                table: "Alunos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imc",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "Percentil",
                table: "Alunos");
        }
    }
}
