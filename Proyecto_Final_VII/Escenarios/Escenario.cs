using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
namespace Escenarios
{
    public class Escenario
    {
        public enum ListaTipo
        {
            Configuracion,
            TiempoTrabajoEmpleados,
            Empleados,
            Cargos,
            Empresas
            //Salarios
        }
        public Dictionary<ListaTipo, IEnumerable<IDBEntity>> datos;
        public Escenario()
        {
            datos = new();
        }
    }
}
