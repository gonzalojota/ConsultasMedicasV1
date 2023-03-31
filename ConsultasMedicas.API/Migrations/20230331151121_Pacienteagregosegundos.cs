using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsultasMedicas.API.Migrations
{
    public partial class Pacienteagregosegundos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SegundoApellido",
                table: "Pacientes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SegundoNombre",
                table: "Pacientes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SegundoApellido",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "SegundoNombre",
                table: "Pacientes");
        }
    }
}
