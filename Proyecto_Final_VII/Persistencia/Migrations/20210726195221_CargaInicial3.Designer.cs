﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Persistencia;

namespace Persistencia.Migrations
{
    [DbContext(typeof(EmpresaContext))]
    [Migration("20210726195221_CargaInicial3")]
    partial class CargaInicial3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Modelo.Empresa.Cargo", b =>
                {
                    b.Property<int>("CargoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Area")
                        .HasColumnType("text");

                    b.Property<string>("DescripcionCargo")
                        .HasColumnType("text");

                    b.Property<int>("EmpleadoId")
                        .HasColumnType("integer");

                    b.Property<string>("NombreCargo")
                        .HasColumnType("text");

                    b.HasKey("CargoId");

                    b.ToTable("cargos");
                });

            modelBuilder.Entity("Modelo.Empresa.Configuracion", b =>
                {
                    b.Property<int>("ConfiguracionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("HorasExtrasMaximas")
                        .HasColumnType("integer");

                    b.Property<int>("HorasExtrasMinimas")
                        .HasColumnType("integer");

                    b.Property<string>("NombreEmpresa")
                        .HasColumnType("text");

                    b.Property<float>("SalarioMaximo")
                        .HasColumnType("real");

                    b.Property<float>("SalrioHorasExtras")
                        .HasColumnType("real");

                    b.Property<int>("TiempoVigenteId")
                        .HasColumnType("integer");

                    b.HasKey("ConfiguracionId");

                    b.HasIndex("TiempoVigenteId");

                    b.ToTable("configuraciones");
                });

            modelBuilder.Entity("Modelo.Empresa.Empleado", b =>
                {
                    b.Property<int>("EmpleadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CedulaEmpleado")
                        .HasColumnType("text");

                    b.Property<string>("Direccion")
                        .HasColumnType("text");

                    b.Property<string>("EstadoCivilEmpleado")
                        .HasColumnType("text");

                    b.Property<string>("NombreEmpleado")
                        .HasColumnType("text");

                    b.Property<int>("NumeroHijosEmpleado")
                        .HasColumnType("integer");

                    b.Property<string>("Telefono")
                        .HasColumnType("text");

                    b.HasKey("EmpleadoId");

                    b.ToTable("empleados");
                });

            modelBuilder.Entity("Modelo.Empresa.Empresa", b =>
                {
                    b.Property<int>("EmpresaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CargoId")
                        .HasColumnType("integer");

                    b.Property<string>("DireccionSucursalEmpresa")
                        .HasColumnType("text");

                    b.Property<string>("RUC")
                        .HasColumnType("text");

                    b.Property<string>("TelefonoEmpresa")
                        .HasColumnType("text");

                    b.Property<int>("TiempoTrabajoEmpleadoId")
                        .HasColumnType("integer");

                    b.HasKey("EmpresaId");

                    b.HasIndex("CargoId");

                    b.HasIndex("TiempoTrabajoEmpleadoId");

                    b.ToTable("empresas");
                });

            modelBuilder.Entity("Modelo.Empresa.Salario", b =>
                {
                    b.Property<int>("SalarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CargoId")
                        .HasColumnType("integer");

                    b.Property<float>("DecimoCuartoSueldo")
                        .HasColumnType("real");

                    b.Property<float>("DecimoTercerSueldo")
                        .HasColumnType("real");

                    b.Property<int>("EmpleadoId")
                        .HasColumnType("integer");

                    b.Property<string>("Estado")
                        .HasColumnType("text");

                    b.Property<float>("SueldoBasico")
                        .HasColumnType("real");

                    b.Property<int>("TiempoTrabajoEmpleadoId")
                        .HasColumnType("integer");

                    b.Property<float>("Utilidades")
                        .HasColumnType("real");

                    b.HasKey("SalarioId");

                    b.HasIndex("CargoId");

                    b.HasIndex("EmpleadoId");

                    b.HasIndex("TiempoTrabajoEmpleadoId");

                    b.ToTable("salarios");
                });

            modelBuilder.Entity("Modelo.Empresa.Salario_Det", b =>
                {
                    b.Property<int>("Salario_DetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("CargoId")
                        .HasColumnType("integer");

                    b.Property<int>("CragoId")
                        .HasColumnType("integer");

                    b.Property<int>("EmpresaId")
                        .HasColumnType("integer");

                    b.Property<int>("SalarioId")
                        .HasColumnType("integer");

                    b.HasKey("Salario_DetId");

                    b.HasIndex("CargoId");

                    b.HasIndex("EmpresaId");

                    b.HasIndex("SalarioId");

                    b.ToTable("salario_dets");
                });

            modelBuilder.Entity("Modelo.Empresa.TiempoTrabajoEmpleado", b =>
                {
                    b.Property<int>("TiempoTrabajoEmpleadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CargoId")
                        .HasColumnType("integer");

                    b.Property<int>("EmpleadoId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("FechaFinTrabajo")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("FechaInicioTrabajo")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("TiempoTrabajoEmpleadoId");

                    b.ToTable("tiempotrabajoempleados");
                });

            modelBuilder.Entity("Modelo.Empresa.Configuracion", b =>
                {
                    b.HasOne("Modelo.Empresa.TiempoTrabajoEmpleado", "TiempoVigente")
                        .WithMany()
                        .HasForeignKey("TiempoVigenteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TiempoVigente");
                });

            modelBuilder.Entity("Modelo.Empresa.Empresa", b =>
                {
                    b.HasOne("Modelo.Empresa.Cargo", "Cargo")
                        .WithMany("Empresas")
                        .HasForeignKey("CargoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Empresa.TiempoTrabajoEmpleado", "TiempoTrabajoEmpleado")
                        .WithMany("Empresas")
                        .HasForeignKey("TiempoTrabajoEmpleadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cargo");

                    b.Navigation("TiempoTrabajoEmpleado");
                });

            modelBuilder.Entity("Modelo.Empresa.Salario", b =>
                {
                    b.HasOne("Modelo.Empresa.Cargo", "Cargo")
                        .WithMany()
                        .HasForeignKey("CargoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Empresa.Empleado", "Empleado")
                        .WithMany("Salarios")
                        .HasForeignKey("EmpleadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Empresa.TiempoTrabajoEmpleado", "TiempoTrabajoEmpleado")
                        .WithMany("Salarios")
                        .HasForeignKey("TiempoTrabajoEmpleadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cargo");

                    b.Navigation("Empleado");

                    b.Navigation("TiempoTrabajoEmpleado");
                });

            modelBuilder.Entity("Modelo.Empresa.Salario_Det", b =>
                {
                    b.HasOne("Modelo.Empresa.Cargo", "Cargo")
                        .WithMany()
                        .HasForeignKey("CargoId");

                    b.HasOne("Modelo.Empresa.Empresa", "Empresa")
                        .WithMany("Salario_Dets")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Empresa.Salario", "Salario")
                        .WithMany("Salario_Dets")
                        .HasForeignKey("SalarioId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Cargo");

                    b.Navigation("Empresa");

                    b.Navigation("Salario");
                });

            modelBuilder.Entity("Modelo.Empresa.Cargo", b =>
                {
                    b.Navigation("Empresas");
                });

            modelBuilder.Entity("Modelo.Empresa.Empleado", b =>
                {
                    b.Navigation("Salarios");
                });

            modelBuilder.Entity("Modelo.Empresa.Empresa", b =>
                {
                    b.Navigation("Salario_Dets");
                });

            modelBuilder.Entity("Modelo.Empresa.Salario", b =>
                {
                    b.Navigation("Salario_Dets");
                });

            modelBuilder.Entity("Modelo.Empresa.TiempoTrabajoEmpleado", b =>
                {
                    b.Navigation("Empresas");

                    b.Navigation("Salarios");
                });
#pragma warning restore 612, 618
        }
    }
}
