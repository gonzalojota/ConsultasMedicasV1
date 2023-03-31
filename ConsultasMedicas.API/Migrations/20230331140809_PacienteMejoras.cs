using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsultasMedicas.API.Migrations
{
    public partial class PacienteMejoras : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TelefonoContacto",
                table: "Pacientes",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TelefonoContacto",
                table: "Pacientes");
        }
    }
}
