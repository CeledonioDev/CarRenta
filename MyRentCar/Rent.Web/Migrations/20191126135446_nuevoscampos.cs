using Microsoft.EntityFrameworkCore.Migrations;

namespace Rent.Web.Migrations
{
    public partial class nuevoscampos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Vehiculos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagenUrl",
                table: "Vehiculos",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Precio",
                table: "Vehiculos",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "ImagenUrl",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "Precio",
                table: "Vehiculos");
        }
    }
}
