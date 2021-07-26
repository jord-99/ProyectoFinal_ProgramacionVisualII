using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Empresa;
using Escenarios;
using Persistencia;
using Procesos;
using Microsoft.EntityFrameworkCore;

namespace Simulacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Escenario01 escenario = new Escenario01();
            EscenarioControl control = new EscenarioControl();
            control.Grabar(escenario);
            // Código para crear los salarios
            var datosSalarios = new DatosSalarios();
            datosSalarios.Generar();

            // Regla del negocio: validación de salarios
            using (var db = new EmpresaContext())
            {
                var listaSalarios = db.salarios
                    .Include(matr => matr.Empleado)
                    .Where(matr => matr.Estado == "Pendiente")
                    .ToList();
                foreach (var salario in listaSalarios)
                {
                    Console.WriteLine(
                        String.Format(
                            "  - {0} Salario Id: {1} Estado: {2}",
                            salario.Empleado.NombreEmpleado,
                            salario.SalarioId,
                            SalarioProc.SalarioAprobada(salario.SalarioId) ? "Aprobada" : "Rechazada"
                        )
                    );
                }
            }
        }
    }
}
