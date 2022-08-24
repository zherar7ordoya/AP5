using Microsoft.EntityFrameworkCore.Migrations;

namespace Menpos.Persistence.Migrations
{
    public partial class Establecimiento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstablishmentId",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "NivelCuentasContables",
                table: "Empresa");

            migrationBuilder.AddColumn<int>(
                name: "EstablecimientoId",
                table: "Empresa",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LicenciaId",
                table: "Empresa",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstablecimientoId",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "LicenciaId",
                table: "Empresa");

            migrationBuilder.AddColumn<int>(
                name: "EstablishmentId",
                table: "Empresa",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NivelCuentasContables",
                table: "Empresa",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
