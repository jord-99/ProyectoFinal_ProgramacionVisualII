using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escenarios;
using Modelo.Empresa;
using Persistencia;
using static Escenarios.Escenario;

namespace Simulacion
{
    public class EscenarioControl
    {
        public void Grabar(IEscenario escenario)
        {
            var datos = escenario.Carga();

            using (var db = new EmpresaContext())
            {
                // Reiniciamos la base de datos
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
                // Insertamos los datos
                db.configuraciones.AddRange((List<Configuracion>)datos[ListaTipo.Configuracion]);
                db.empleados.AddRange((List<Empleado>)datos[ListaTipo.Empleados]);
                db.tiempotrabajoempleados.AddRange((List<TiempoTrabajoEmpleado>)datos[ListaTipo.TiempoTrabajoEmpleados]);
                db.cargos.AddRange((List<Cargo>)datos[ListaTipo.Cargos]);
                db.empresas.AddRange((List<Empresa>)datos[ListaTipo.Empresas]);
                //''db.salarios.AddRange((List<Salario>)datos[ListaTipo.Salarios]);

                // Genera la persistencia
                db.SaveChanges();
            }
        }

    }
}
