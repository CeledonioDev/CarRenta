using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rent.Web.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehiculoCaracteristica_Vehiculos_VehiculoId",
                table: "VehiculoCaracteristica");

            migrationBuilder.DropForeignKey(
                name: "FK_VehiculoPublicacion_Vehiculos_VehiculoId",
                table: "VehiculoPublicacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VehiculoPublicacion",
                table: "VehiculoPublicacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VehiculoCaracteristica",
                table: "VehiculoCaracteristica");

            migrationBuilder.RenameTable(
                name: "VehiculoPublicacion",
                newName: "vehiculoPublicacions");

            migrationBuilder.RenameTable(
                name: "VehiculoCaracteristica",
                newName: "VehiculoCaracteristicas");

            migrationBuilder.RenameIndex(
                name: "IX_VehiculoPublicacion_VehiculoId",
                table: "vehiculoPublicacions",
                newName: "IX_vehiculoPublicacions_VehiculoId");

            migrationBuilder.RenameIndex(
                name: "IX_VehiculoCaracteristica_VehiculoId",
                table: "VehiculoCaracteristicas",
                newName: "IX_VehiculoCaracteristicas_VehiculoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_vehiculoPublicacions",
                table: "vehiculoPublicacions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehiculoCaracteristicas",
                table: "VehiculoCaracteristicas",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "MarcaVehiculos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarcaVehiculos", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_VehiculoCaracteristicas_Vehiculos_VehiculoId",
                table: "VehiculoCaracteristicas",
                column: "VehiculoId",
                principalTable: "Vehiculos",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehiculoCaracteristicas_Vehiculos_VehiculoId",
                table: "VehiculoCaracteristicas");

            migrationBuilder.DropForeignKey(
                name: "FK_vehiculoPublicacions_Vehiculos_VehiculoId",
                table: "vehiculoPublicacions");

            migrationBuilder.DropTable(
                name: "MarcaVehiculos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_vehiculoPublicacions",
                table: "vehiculoPublicacions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VehiculoCaracteristicas",
                table: "VehiculoCaracteristicas");

            migrationBuilder.RenameTable(
                name: "vehiculoPublicacions",
                newName: "VehiculoPublicacion");

            migrationBuilder.RenameTable(
                name: "VehiculoCaracteristicas",
                newName: "VehiculoCaracteristica");

            migrationBuilder.RenameIndex(
                name: "IX_vehiculoPublicacions_VehiculoId",
                table: "VehiculoPublicacion",
                newName: "IX_VehiculoPublicacion_VehiculoId");

            migrationBuilder.RenameIndex(
                name: "IX_VehiculoCaracteristicas_VehiculoId",
                table: "VehiculoCaracteristica",
                newName: "IX_VehiculoCaracteristica_VehiculoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehiculoPublicacion",
                table: "VehiculoPublicacion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehiculoCaracteristica",
                table: "VehiculoCaracteristica",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VehiculoCaracteristica_Vehiculos_VehiculoId",
                table: "VehiculoCaracteristica",
                column: "VehiculoId",
                principalTable: "Vehiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VehiculoPublicacion_Vehiculos_VehiculoId",
                table: "VehiculoPublicacion",
                column: "VehiculoId",
                principalTable: "Vehiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
