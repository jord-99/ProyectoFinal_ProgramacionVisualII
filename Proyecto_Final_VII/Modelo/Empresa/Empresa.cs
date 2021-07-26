using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Empresa
{
    public class Empresa : IDBEntity
    {
        public int EmpresaId { get; set; }
        public string RUC { get; set; }
        public string DireccionSucursalEmpresa { get; set; }
        public string TelefonoEmpresa { get; set; }
        public Cargo Cargo { get; set; }
        public int CargoId { get; set; }
        public TiempoTrabajoEmpleado TiempoTrabajoEmpleado { get; set; }
        public int TiempoTrabajoEmpleadoId { get; set; }
        public List<Salario_Det> Salario_Dets { get; set; }
    }
}
