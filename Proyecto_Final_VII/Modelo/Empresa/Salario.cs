using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Empresa
{
    public class Salario : IDBEntity
    {
        public int SalarioId { get; set; }
        public string Estado { get; set; }   // PENdiente, APRobada, ANUlada
        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }
        public int TiempoTrabajoEmpleadoId { get; set; }
        public TiempoTrabajoEmpleado TiempoTrabajoEmpleado { get; set; }
        public float SueldoBasico { get; set; }
        public float DecimoTercerSueldo { get; set; }
        public float DecimoCuartoSueldo { get; set; }
        public float Utilidades { get; set; }
        public int CargoId { get; set; }
        public Cargo Cargo { get; set; }
        public List<Salario_Det> Salario_Dets { get; set; }

        public float decimotercersueldo(float sueldobasico)
        {
            // Cálculo
            float suma = 0;
            suma += MathF.Round((sueldobasico * 12)/12, 2);
            //Víctor:
            //Fecha: 23/07/2021
            //Mejora en el cálculo de la nota final
            //suma = MathF.Round(suma, 2);            
            return suma;
        }
        public bool Apruebaaldecimo(float sueldobasico, float SalarioMinima)
        {
            bool res;
            res = decimotercersueldo(sueldobasico) >= SalarioMinima;
            return res;
        }
    }
}
