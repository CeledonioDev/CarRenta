using Microsoft.EntityFrameworkCore.Migrations;

namespace Rent.Web.Migrations
{
    public partial class newRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NoChasis",
                table: "Vehiculos",
                newName: "No_Chasis");

            migrationBuilder.RenameColumn(
                name: "Ano",
                table: "Vehiculos",
                newName: "Anio_Vehiculo");

            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "TiposVehiculos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VehiculoId",
                table: "TiposVehiculos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VehiculoId",
                table: "ModeloVehiculos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TiposVehiculos_VehiculoId",
                table: "TiposVehiculos",
                column: "VehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_ModeloVehiculos_VehiculoId",
                table: "ModeloVehiculos",
                column: "VehiculoId");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ModeloVehiculos_Vehiculos_VehiculoId",
                table: "ModeloVehiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_TiposVehiculos_Vehiculos_VehiculoId",
                table: "TiposVehiculos");

            migrationBuilder.DropIndex(
                name: "IX_TiposVehiculos_VehiculoId",
                table: "TiposVehiculos");

            migrationBuilder.DropIndex(
                name: "IX_ModeloVehiculos_VehiculoId",
                table: "ModeloVehiculos");

            migrationBuilder.DropColumn(
                name: "VehiculoId",
                table: "TiposVehiculos");

            migrationBuilder.DropColumn(
                name: "VehiculoId",
                table: "ModeloVehiculos");

            migrationBuilder.RenameColumn(
                name: "No_Chasis",
                table: "Vehiculos",
                newName: "NoChasis");

            migrationBuilder.RenameColumn(
                name: "Anio_Vehiculo",
                table: "Vehiculos",
                newName: "Ano");

            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "TiposVehiculos",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
