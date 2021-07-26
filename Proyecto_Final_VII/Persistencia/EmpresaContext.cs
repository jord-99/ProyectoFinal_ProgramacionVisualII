using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Modelo.Empresa;

namespace Persistencia
{
    public class EmpresaContext: DbContext
    {
        public DbSet<Cargo> cargos { get; set; }
        public DbSet<Configuracion> configuraciones { get; set; }
        public DbSet<Empleado> empleados { get; set; }
        public DbSet<Empresa> empresas { get; set; }
        public DbSet<Salario> salarios { get; set; }
        public DbSet<Salario_Det> salario_dets { get; set; }
        public DbSet<TiempoTrabajoEmpleado> tiempotrabajoempleados { get; set; }

        public EmpresaContext() : base()
        {

        }
        public EmpresaContext(DbContextOptions<EmpresaContext> opciones)
            : base(opciones)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                EmpresaConfig.ContextOptions(optionsBuilder);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuracion
            modelBuilder.Entity<Configuracion>()
                .HasOne(config => config.TiempoVigente)
                .WithMany()
                .HasForeignKey(configs => configs.TiempoVigenteId);

            // Relación uno a muchos; un Empleado tiene muchos Salarios
            modelBuilder.Entity<Salario>()
                .HasOne(sal => sal.TiempoTrabajoEmpleado)
                .WithMany(emple => emple.Salarios)
                .HasForeignKey(emp => emp.TiempoTrabajoEmpleadoId);

            // Relación uno a muchos; en un Tiempo de Trabajo se registran varios Salarios
            modelBuilder.Entity<Salario>()
                .HasOne(tiemp => tiemp.Empleado)
                .WithMany(temp => temp.Salarios)
                .HasForeignKey(sal => sal.EmpleadoId);

            // Relación de uno a muchos: cabecera detalle del salario
            modelBuilder.Entity<Salario_Det>()
                .HasOne(det => det.Salario)
                .WithMany(sal => sal.Salario_Dets)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(saldet => saldet.SalarioId);

            // Relación de uno a muchos: Empresa con detalles del salario
            modelBuilder.Entity<Salario_Det>()
                .HasOne(det => det.Empresa)
                .WithMany(emp => emp.Salario_Dets)
                .HasForeignKey(dets => dets.EmpresaId);

            // Relación uno a muchos; una Materia se dicta en muchos Cursos
            modelBuilder.Entity<Empresa>()
                .HasOne(emp => emp.Cargo)
                .WithMany(car => car.Empresas)
                .HasForeignKey(caremp => caremp.CargoId);

     

            // Relación uno a muchos; un Período tiene varios cursos
            modelBuilder.Entity<Empresa>()
                .HasOne(emp => emp.TiempoTrabajoEmpleado)
                .WithMany(ttp => ttp.Empresas)
                .HasForeignKey(empt => empt.TiempoTrabajoEmpleadoId);

            _ = modelBuilder.Entity<TiempoTrabajoEmpleado>()
                .HasOne(empl => empl.Empleado)
                .WithMany(ttpp => ttpp.TiempoTrabajoEmpleados)
                .HasForeignKey(empt => empt.EmpleadoId);
        }


    }
}
