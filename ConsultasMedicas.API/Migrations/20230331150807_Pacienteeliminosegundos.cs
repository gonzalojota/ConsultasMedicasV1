using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsultasMedicas.API.Migrations
{
    public partial class Pacienteeliminosegundos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SegundoApellido",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "SegundoNombre",
                table: "Pacientes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SegundoApellido",
                table: "Pacientes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SegundoNombre",
                table: "Pacientes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }
    }
}
