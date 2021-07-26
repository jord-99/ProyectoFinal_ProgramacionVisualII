using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Empresa
{
    public class Configuracion : IDBEntity
    {
        public int ConfiguracionId { get; set; }
        public float SalarioMaximo { get; set; }
        public string NombreEmpresa { get; set; }
        public int HorasExtrasMinimas { get; set; }
        public int HorasExtrasMaximas { get; set; }
        public float SalrioHorasExtras { get; set; }
        public TiempoTrabajoEmpleado TiempoVigente { get; set; }
        public int TiempoVigenteId { get; set; }
    }
}
