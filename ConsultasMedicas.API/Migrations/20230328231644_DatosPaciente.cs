using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsultasMedicas.API.Migrations
{
    public partial class DatosPaciente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaDiagnostico",
                table: "Pacientes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaDiagnostico",
                table: "Pacientes");
        }
    }
}
