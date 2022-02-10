using Microsoft.EntityFrameworkCore.Migrations;

namespace Desafio8QualiV2.Migrations
{
    public partial class DetalhesAlterados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Created",
                table: "Usuarios",
                newName: "Create");

            migrationBuilder.RenameColumn(
                name: "Changed",
                table: "Usuarios",
                newName: "Change");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Create",
                table: "Usuarios",
                newName: "Created");

            migrationBuilder.RenameColumn(
                name: "Change",
                table: "Usuarios",
                newName: "Changed");
        }
    }
}
