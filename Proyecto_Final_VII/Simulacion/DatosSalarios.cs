using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Empresa;
using Persistencia;
using Procesos;
using Modelo;
namespace Simulacion
{
    public class DatosSalarios
    {
        public enum SalarioEstados { Pendiente, Aprobada, Rechazada };
        public void Generar()
        {
            // Empleado y cargo
            string empNombre = "Luis Guitierrez";
            string cargoNombre = "Gerente de Marketing";
            //string sueldobasico = "400.00";
            // Matrícula de segundo nivel
            Salario salarioLuis2019;
            DateTime dt2019 = new DateTime(2019, 2, 1);
            string[] empresa2019 = new string[] {
                "Tecnomega C.A", };
                
            // Salario en el periodo 2019
            Dictionary<string, Salario> dicSalarioLuis2019 = new()
            {
                {
                    empresa2019[0],
                    new Salario() { DecimoTercerSueldo = 535.00f, DecimoCuartoSueldo = 183.01f, Utilidades = 730.00f }
                },
            };

            // Salario periodo 2020
            Salario salarioLuis2020;
            DateTime dt2020 = new DateTime(2020, 2, 1);
            string[] empresa2020 = new string[] {
                "Tecnomega C.A", };

            // Salario en el periodo 2020
            Dictionary<string, Salario> dicSalarioLuis2020 = new()
            {
                {
                    empresa2020[0],
                    new Salario() { DecimoTercerSueldo = 600.50f, DecimoCuartoSueldo = 200.50f, Utilidades = 800.55f }
                },
            };


            // Persistencia de Luis
            using (var db = new EmpresaContext())
            {
                salarioLuis2019 = SalarioProc.CreaSalario(db,
                    SalarioEstados.Aprobada.ToString(), empNombre, cargoNombre, dt2019, empresa2019);
                SalarioProc.RegistrarSalarios(salarioLuis2019, dicSalarioLuis2019);

                salarioLuis2020 = SalarioProc.CreaSalario(db,
                   SalarioEstados.Aprobada.ToString(), empNombre, cargoNombre, dt2020, empresa2020);
                SalarioProc.RegistrarSalarios(salarioLuis2020, dicSalarioLuis2020);
                
                db.salarios.Add(salarioLuis2019);
                db.salarios.Add(salarioLuis2020);
                db.SaveChanges();
            }
            //----------------------------------------------------------------------------------------------

            // Salario de ANA
            // Empleado y cargo
            empNombre = "Ana Velasquez";
            cargoNombre = "Limpieza";
            //string sueldobasico = "400.00";
            // Matrícula de segundo nivel
            Salario salarioAna2019;
            DateTime dtt2019 = new DateTime(2019, 4, 1);
            string[] empresas2019 = new string[] {
                "Tecnomega C.A", };

            // Salario en el periodo 2019
            Dictionary<string, Salario> dicSalarioAna2019 = new()
            {
                {
                    empresas2019[0],
                    new Salario() { DecimoTercerSueldo = 500.00f, DecimoCuartoSueldo = 248.77f, Utilidades = 1500.00f }
                },
            };

            // Salario periodo 2020
            Salario salarioAna2020;
            DateTime dtt2020 = new DateTime(2020, 5, 1);
            string[] empresas2020 = new string[] {
                "Tecnomega C.A", };

            // Salario en el periodo 2020
            Dictionary<string, Salario> dicSalarioAna2020 = new()
            {
                {
                    empresas2020[0],
                    new Salario() { DecimoTercerSueldo = 600.50f, DecimoCuartoSueldo = 270.50f, Utilidades = 1300.55f }
                },
            };


            // Persistencia de Ana
            using (var db = new EmpresaContext())
            {
                salarioAna2019 = SalarioProc.CreaSalario(db,
                    SalarioEstados.Aprobada.ToString(), empNombre, cargoNombre, dtt2019, empresas2019);
                SalarioProc.RegistrarSalarios(salarioAna2019, dicSalarioAna2019);

                salarioAna2020 = SalarioProc.CreaSalario(db,
                   SalarioEstados.Aprobada.ToString(), empNombre, cargoNombre, dtt2020, empresas2020);
                SalarioProc.RegistrarSalarios(salarioAna2020, dicSalarioAna2020);

                db.salarios.Add(salarioAna2019);
                db.salarios.Add(salarioAna2020);
                db.SaveChanges();
            }
            //----------------------------------------------------------------------------------------------
            
            //salario ROSA
            empNombre = "Rosa Perez";
            cargoNombre = "Limpieza";
            //string sueldobasico = "400.00";
            // Matrícula de segundo nivel
            Salario salarioRosa2019;
            DateTime dttt2019 = new DateTime(2019, 5, 1);
            string[] empresass2019 = new string[] {
                "Tecnomega C.A", };

            // Salario en el periodo 2019
            Dictionary<string, Salario> dicSalarioRosa2019 = new()
            {
                {
                    empresass2019[0],
                    new Salario() { DecimoTercerSueldo = 500.00f, DecimoCuartoSueldo = 248.77f, Utilidades = 1500.00f }
                },
            };

            // Salario periodo 2020
            Salario salarioRosa2020;
            DateTime dttt2020 = new DateTime(2020, 2, 1);
            string[] empresass2020 = new string[] {
                "Tecnomega C.A", };

            // Salario en el periodo 2020
            Dictionary<string, Salario> dicSalarioRosa2020 = new()
            {
                {
                    empresass2020[0],
                    new Salario() { DecimoTercerSueldo = 600.50f, DecimoCuartoSueldo = 270.50f, Utilidades = 1300.55f }
                },
            };

            // Salario periodo 2020
            Salario salarioRosa2021;
            DateTime dttt2021 = new DateTime(2021, 2, 1);
            string[] empresass2021 = new string[] {
                "Tecnomega C.A", };

            // Salario en el periodo 2020
            Dictionary<string, Salario> dicSalarioRosa2021 = new()
            {
                {
                    empresass2021[0],
                    new Salario() { DecimoTercerSueldo = 600.50f, DecimoCuartoSueldo = 270.50f, Utilidades = 1300.55f }
                },
            };

            // Persistencia de Rosa
            using (var db = new EmpresaContext())
            {
                salarioRosa2019 = SalarioProc.CreaSalario(db,
                    SalarioEstados.Aprobada.ToString(), empNombre, cargoNombre, dttt2019, empresass2019);
                SalarioProc.RegistrarSalarios(salarioRosa2019, dicSalarioRosa2019);

                salarioRosa2020 = SalarioProc.CreaSalario(db,
                   SalarioEstados.Aprobada.ToString(), empNombre, cargoNombre, dttt2020, empresass2020);
                SalarioProc.RegistrarSalarios(salarioRosa2020, dicSalarioRosa2020);

                salarioRosa2021 = SalarioProc.CreaSalario(db,
                   SalarioEstados.Aprobada.ToString(), empNombre, cargoNombre, dttt2021, empresass2021);
                SalarioProc.RegistrarSalarios(salarioRosa2021, dicSalarioRosa2021);

                db.salarios.Add(salarioRosa2019);
                db.salarios.Add(salarioRosa2020);
                db.salarios.Add(salarioRosa2021);
                db.SaveChanges();
            }


        }

    }
}
