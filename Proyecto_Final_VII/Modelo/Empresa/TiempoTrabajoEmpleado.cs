using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Empresa
{
    public class TiempoTrabajoEmpleado : IDBEntity
    {
        public int TiempoTrabajoEmpleadoId { get; set; }
        public DateTime FechaInicioTrabajo { get; set; }
        public DateTime FechaFinTrabajo { get; set; }
        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }
        public int CargoId { get; set; }
        public Cargo Cargo { get; set; }
        public List<Salario> Salarios { get; set; }
        public List<Empresa> Empresas { get; set; }
    }
}
