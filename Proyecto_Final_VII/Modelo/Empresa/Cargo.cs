using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Empresa
{
    public class Cargo : IDBEntity
    {
        public int CargoId { get; set; }
        public string NombreCargo { get; set; }
        public string DescripcionCargo { get; set; }
        public int EmpleadoId { get; set; }
        public string Area { get; set; }
        public TiempoTrabajoEmpleado TiempoTrabajoEmpleado { get; set; }
        public List<Empresa> Empresas { get; set; }
    }
}
