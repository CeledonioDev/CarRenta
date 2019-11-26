using Microsoft.EntityFrameworkCore.Migrations;

namespace Rent.Web.Migrations
{
    public partial class correcion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MarcaVehiculos_Vehiculos_VehiculoId",
                table: "MarcaVehiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_ModeloVehiculos_Vehiculos_VehiculoId",
                table: "ModeloVehiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_TiposVehiculos_Vehiculos_VehiculoId",
                table: "TiposVehiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_VehiculoCaracteristicas_Vehiculos_VehiculoId",
                table: "VehiculoCaracteristicas");

            migrationBuilder.DropForeignKey(
                name: "FK_VehiculoCaracteristicas_VehiculoCaracteristicas_VehiculocaracteristicaId",
                table: "VehiculoCaracteristicas");

            migrationBuilder.DropForeignKey(
                name: "FK_vehiculoPublicacions_Vehiculos_VehiculoId",
                table: "vehiculoPublicacions");

            migrationBuilder.DropIndex(
                name: "IX_vehiculoPublicacions_VehiculoId",
                table: "vehiculoPublicacions");

            migrationBuilder.DropIndex(
                name: "IX_VehiculoCaracteristicas_VehiculoId",
                table: "VehiculoCaracteristicas");

            migrationBuilder.DropIndex(
                name: "IX_VehiculoCaracteristicas_VehiculocaracteristicaId",
                table: "VehiculoCaracteristicas");

            migrationBuilder.DropIndex(
                name: "IX_TiposVehiculos_VehiculoId",
                table: "TiposVehiculos");

            migrationBuilder.DropIndex(
                name: "IX_ModeloVehiculos_VehiculoId",
                table: "ModeloVehiculos");

            migrationBuilder.DropIndex(
                name: "IX_MarcaVehiculos_VehiculoId",
                table: "MarcaVehiculos");

            migrationBuilder.DropColumn(
                name: "VehiculoId",
                table: "vehiculoPublicacions");

            migrationBuilder.DropColumn(
                name: "VehiculoId",
                table: "VehiculoCaracteristicas");

            migrationBuilder.DropColumn(
                name: "VehiculocaracteristicaId",
                table: "VehiculoCaracteristicas");

            migrationBuilder.DropColumn(
                name: "VehiculoId",
                table: "TiposVehiculos");

            migrationBuilder.DropColumn(
                name: "VehiculoId",
                table: "ModeloVehiculos");

            migrationBuilder.DropColumn(
                name: "VehiculoId",
                table: "MarcaVehiculos");

            migrationBuilder.AddColumn<int>(
                name: "MarcaVehiculosId",
                table: "Vehiculos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModeloVehiculosId",
                table: "Vehiculos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TiposVehiculosId",
                table: "Vehiculos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VehiculoCaracteristicasId",
                table: "Vehiculos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VehiculoPublicacionsId",
                table: "Vehiculos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_MarcaVehiculosId",
                table: "Vehiculos",
                column: "MarcaVehiculosId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_ModeloVehiculosId",
                table: "Vehiculos",
                column: "ModeloVehiculosId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_TiposVehiculosId",
                table: "Vehiculos",
                column: "TiposVehiculosId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_VehiculoCaracteristicasId",
                table: "Vehiculos",
                column: "VehiculoCaracteristicasId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_VehiculoPublicacionsId",
                table: "Vehiculos",
                column: "VehiculoPublicacionsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_MarcaVehiculos_MarcaVehiculosId",
                table: "Vehiculos",
                column: "MarcaVehiculosId",
                principalTable: "MarcaVehiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_ModeloVehiculos_ModeloVehiculosId",
                table: "Vehiculos",
                column: "ModeloVehiculosId",
                principalTable: "ModeloVehiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_TiposVehiculos_TiposVehiculosId",
                table: "Vehiculos",
                column: "TiposVehiculosId",
                principalTable: "TiposVehiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_VehiculoCaracteristicas_VehiculoCaracteristicasId",
                table: "Vehiculos",
                column: "VehiculoCaracteristicasId",
                principalTable: "VehiculoCaracteristicas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_vehiculoPublicacions_VehiculoPublicacionsId",
                table: "Vehiculos",
                column: "VehiculoPublicacionsId",
                principalTable: "vehiculoPublicacions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_MarcaVehiculos_MarcaVehiculosId",
                table: "Vehiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_ModeloVehiculos_ModeloVehiculosId",
                table: "Vehiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_TiposVehiculos_TiposVehiculosId",
                table: "Vehiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_VehiculoCaracteristicas_VehiculoCaracteristicasId",
                table: "Vehiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_vehiculoPublicacions_VehiculoPublicacionsId",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_MarcaVehiculosId",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_ModeloVehiculosId",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_TiposVehiculosId",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_VehiculoCaracteristicasId",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_VehiculoPublicacionsId",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "MarcaVehiculosId",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "ModeloVehiculosId",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "TiposVehiculosId",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "VehiculoCaracteristicasId",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "VehiculoPublicacionsId",
                table: "Vehiculos");

            migrationBuilder.AddColumn<int>(
                name: "VehiculoId",
                table: "vehiculoPublicacions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VehiculoId",
                table: "VehiculoCaracteristicas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VehiculocaracteristicaId",
                table: "VehiculoCaracteristicas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VehiculoId",
                table: "TiposVehiculos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VehiculoId",
                table: "ModeloVehiculos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VehiculoId",
                table: "MarcaVehiculos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_vehiculoPublicacions_VehiculoId",
                table: "vehiculoPublicacions",
                column: "VehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_VehiculoCaracteristicas_VehiculoId",
                table: "VehiculoCaracteristicas",
                column: "VehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_VehiculoCaracteristicas_VehiculocaracteristicaId",
                table: "VehiculoCaracteristicas",
                column: "VehiculocaracteristicaId");

            migrationBuilder.CreateIndex(
                name: "IX_TiposVehiculos_VehiculoId",
                table: "TiposVehiculos",
                column: "VehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_ModeloVehiculos_VehiculoId",
                table: "ModeloVehiculos",
                column: "VehiculoId");

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
                name: "FK_ModeloVehiculos_Vehiculos_VehiculoId",
                table: "ModeloVehiculos",
                column: "VehiculoId",
                principalTable: "Vehiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TiposVehiculos_Vehiculos_VehiculoId",
                table: "TiposVehiculos",
                column: "VehiculoId",
                principalTable: "Vehiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VehiculoCaracteristicas_Vehiculos_VehiculoId",
                table: "VehiculoCaracteristicas",
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

            migrationBuilder.AddForeignKey(
                name: "FK_vehiculoPublicacions_Vehiculos_VehiculoId",
                table: "vehiculoPublicacions",
                column: "VehiculoId",
                principalTable: "Vehiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
