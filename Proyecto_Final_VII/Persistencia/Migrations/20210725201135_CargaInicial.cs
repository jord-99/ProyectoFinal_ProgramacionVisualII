using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Persistencia.Migrations
{
    public partial class CargaInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cargos",
                columns: table => new
                {
                    CargoId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreCargo = table.Column<string>(type: "text", nullable: true),
                    DescripcionCargo = table.Column<string>(type: "text", nullable: true),
                    EmpleadoId = table.Column<int>(type: "integer", nullable: false),
                    Area = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cargos", x => x.CargoId);
                });

            migrationBuilder.CreateTable(
                name: "empleados",
                columns: table => new
                {
                    EmpleadoId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreEmpleado = table.Column<string>(type: "text", nullable: true),
                    CedulaEmpleado = table.Column<string>(type: "text", nullable: true),
                    Telefono = table.Column<string>(type: "text", nullable: true),
                    Direccion = table.Column<string>(type: "text", nullable: true),
                    EstadoCivilEmpleado = table.Column<string>(type: "text", nullable: true),
                    NumeroHijosEmpleado = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empleados", x => x.EmpleadoId);
                });

            migrationBuilder.CreateTable(
                name: "tiempotrabajoempleados",
                columns: table => new
                {
                    TiempoTrabajoEmpleadoId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FechaInicioTrabajo = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    FechaFinTrabajo = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    EmpleadoId = table.Column<int>(type: "integer", nullable: false),
                    CargoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tiempotrabajoempleados", x => x.TiempoTrabajoEmpleadoId);
                });

            migrationBuilder.CreateTable(
                name: "configuraciones",
                columns: table => new
                {
                    ConfiguracionId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SalarioMaximo = table.Column<float>(type: "real", nullable: false),
                    NombreEmpresa = table.Column<string>(type: "text", nullable: true),
                    HorasExtrasMinimas = table.Column<int>(type: "integer", nullable: false),
                    HorasExtrasMaximas = table.Column<int>(type: "integer", nullable: false),
                    SalrioHorasExtras = table.Column<float>(type: "real", nullable: false),
                    TiempoVigenteId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_configuraciones", x => x.ConfiguracionId);
                    table.ForeignKey(
                        name: "FK_configuraciones_tiempotrabajoempleados_TiempoVigenteId",
                        column: x => x.TiempoVigenteId,
                        principalTable: "tiempotrabajoempleados",
                        principalColumn: "TiempoTrabajoEmpleadoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "empresas",
                columns: table => new
                {
                    EmpresaId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RUC = table.Column<string>(type: "text", nullable: true),
                    DireccionSucursalEmpresa = table.Column<string>(type: "text", nullable: true),
                    TelefonoEmpresa = table.Column<string>(type: "text", nullable: true),
                    CargoId = table.Column<int>(type: "integer", nullable: false),
                    TiempoTrabajoEmpleadoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empresas", x => x.EmpresaId);
                    table.ForeignKey(
                        name: "FK_empresas_cargos_CargoId",
                        column: x => x.CargoId,
                        principalTable: "cargos",
                        principalColumn: "CargoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_empresas_tiempotrabajoempleados_TiempoTrabajoEmpleadoId",
                        column: x => x.TiempoTrabajoEmpleadoId,
                        principalTable: "tiempotrabajoempleados",
                        principalColumn: "TiempoTrabajoEmpleadoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "salarios",
                columns: table => new
                {
                    SalarioId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmpleadoId = table.Column<int>(type: "integer", nullable: false),
                    TiempoTrabajoEmpleadoId = table.Column<int>(type: "integer", nullable: false),
                    SueldoBasico = table.Column<float>(type: "real", nullable: false),
                    DecimoTercerSueldo = table.Column<float>(type: "real", nullable: false),
                    DecimoCuartoSueldo = table.Column<float>(type: "real", nullable: false),
                    Utilidades = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_salarios", x => x.SalarioId);
                    table.ForeignKey(
                        name: "FK_salarios_empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "empleados",
                        principalColumn: "EmpleadoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_salarios_tiempotrabajoempleados_TiempoTrabajoEmpleadoId",
                        column: x => x.TiempoTrabajoEmpleadoId,
                        principalTable: "tiempotrabajoempleados",
                        principalColumn: "TiempoTrabajoEmpleadoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "salario_dets",
                columns: table => new
                {
                    Salario_DetId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmpresaId = table.Column<int>(type: "integer", nullable: false),
                    SalarioId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_salario_dets", x => x.Salario_DetId);
                    table.ForeignKey(
                        name: "FK_salario_dets_empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "empresas",
                        principalColumn: "EmpresaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_salario_dets_salarios_SalarioId",
                        column: x => x.SalarioId,
                        principalTable: "salarios",
                        principalColumn: "SalarioId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_configuraciones_TiempoVigenteId",
                table: "configuraciones",
                column: "TiempoVigenteId");

            migrationBuilder.CreateIndex(
                name: "IX_empresas_CargoId",
                table: "empresas",
                column: "CargoId");

            migrationBuilder.CreateIndex(
                name: "IX_empresas_TiempoTrabajoEmpleadoId",
                table: "empresas",
                column: "TiempoTrabajoEmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_salario_dets_EmpresaId",
                table: "salario_dets",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_salario_dets_SalarioId",
                table: "salario_dets",
                column: "SalarioId");

            migrationBuilder.CreateIndex(
                name: "IX_salarios_EmpleadoId",
                table: "salarios",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_salarios_TiempoTrabajoEmpleadoId",
                table: "salarios",
                column: "TiempoTrabajoEmpleadoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "configuraciones");

            migrationBuilder.DropTable(
                name: "salario_dets");

            migrationBuilder.DropTable(
                name: "empresas");

            migrationBuilder.DropTable(
                name: "salarios");

            migrationBuilder.DropTable(
                name: "cargos");

            migrationBuilder.DropTable(
                name: "empleados");

            migrationBuilder.DropTable(
                name: "tiempotrabajoempleados");
        }
    }
}
