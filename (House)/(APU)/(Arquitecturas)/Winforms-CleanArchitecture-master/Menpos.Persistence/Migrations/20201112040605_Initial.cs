using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Menpos.Persistence.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false, defaultValue: true),
                    EstablishmentId = table.Column<int>(nullable: false),
                    RFC = table.Column<string>(maxLength: 50, nullable: true),
                    RazonSocial = table.Column<string>(maxLength: 100, nullable: true),
                    NombreComercial = table.Column<string>(maxLength: 100, nullable: true),
                    TitularId = table.Column<int>(nullable: false),
                    MonedaStandardId = table.Column<int>(nullable: false),
                    NivelCuentasContables = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empresa");
        }
    }
}
