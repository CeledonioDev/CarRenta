using Microsoft.EntityFrameworkCore.Migrations;

namespace Rent.Web.Migrations
{
    public partial class new_relacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VehiculocaracteristicaId",
                table: "VehiculoCaracteristicas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VehiculoId",
                table: "MarcaVehiculos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VehiculoCaracteristicas_VehiculocaracteristicaId",
                table: "VehiculoCaracteristicas",
                column: "VehiculocaracteristicaId");

            migrationBuilder.CreateIndex(
                name: "IX_MarcaVehiculos_VehiculoId",
                table: "MarcaVehiculos",
                column: "VehiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_MarcaVehiculos_Vehiculos_VehiculoId",
                table: "MarcaVehiculos",
                column: "VehiculoId",
                principalTable: "Vehiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VehiculoCaracteristicas_VehiculoCaracteristicas_VehiculocaracteristicaId",
                table: "VehiculoCaracteristicas",
                column: "VehiculocaracteristicaId",
                principalTable: "VehiculoCaracteristicas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MarcaVehiculos_Vehiculos_VehiculoId",
                table: "MarcaVehiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_VehiculoCaracteristicas_VehiculoCaracteristicas_VehiculocaracteristicaId",
                table: "VehiculoCaracteristicas");

            migrationBuilder.DropIndex(
                name: "IX_VehiculoCaracteristicas_VehiculocaracteristicaId",
                table: "VehiculoCaracteristicas");

            migrationBuilder.DropIndex(
                name: "IX_MarcaVehiculos_VehiculoId",
                table: "MarcaVehiculos");

            migrationBuilder.DropColumn(
                name: "VehiculocaracteristicaId",
                table: "VehiculoCaracteristicas");

            migrationBuilder.DropColumn(
                name: "VehiculoId",
                table: "MarcaVehiculos");
        }
    }
}
