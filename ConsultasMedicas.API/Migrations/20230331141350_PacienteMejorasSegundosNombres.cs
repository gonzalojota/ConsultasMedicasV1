using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsultasMedicas.API.Migrations
{
    public partial class PacienteMejorasSegundosNombres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Pacientes",
                newName: "SegundoNombre");

            migrationBuilder.RenameColumn(
                name: "Apellido",
                table: "Pacientes",
                newName: "SegundoApellido");

            migrationBuilder.AddColumn<string>(
                name: "PrimerApellido",
                table: "Pacientes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PrimerNombre",
                table: "Pacientes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrimerApellido",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "PrimerNombre",
                table: "Pacientes");

            migrationBuilder.RenameColumn(
                name: "SegundoNombre",
                table: "Pacientes",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "SegundoApellido",
                table: "Pacientes",
                newName: "Apellido");
        }
    }
}
