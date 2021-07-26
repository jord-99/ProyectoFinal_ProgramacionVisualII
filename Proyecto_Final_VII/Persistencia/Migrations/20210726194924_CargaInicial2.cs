using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class CargaInicial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CargoId",
                table: "salarios",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "salarios",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CargoId",
                table: "salario_dets",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CragoId",
                table: "salario_dets",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_salarios_CargoId",
                table: "salarios",
                column: "CargoId");

            migrationBuilder.CreateIndex(
                name: "IX_salario_dets_CargoId",
                table: "salario_dets",
                column: "CargoId");

            migrationBuilder.AddForeignKey(
                name: "FK_salario_dets_cargos_CargoId",
                table: "salario_dets",
                column: "CargoId",
                principalTable: "cargos",
                principalColumn: "CargoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_salarios_cargos_CargoId",
                table: "salarios",
                column: "CargoId",
                principalTable: "cargos",
                principalColumn: "CargoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_salario_dets_cargos_CargoId",
                table: "salario_dets");

            migrationBuilder.DropForeignKey(
                name: "FK_salarios_cargos_CargoId",
                table: "salarios");

            migrationBuilder.DropIndex(
                name: "IX_salarios_CargoId",
                table: "salarios");

            migrationBuilder.DropIndex(
                name: "IX_salario_dets_CargoId",
                table: "salario_dets");

            migrationBuilder.DropColumn(
                name: "CargoId",
                table: "salarios");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "salarios");

            migrationBuilder.DropColumn(
                name: "CargoId",
                table: "salario_dets");

            migrationBuilder.DropColumn(
                name: "CragoId",
                table: "salario_dets");
        }
    }
}
