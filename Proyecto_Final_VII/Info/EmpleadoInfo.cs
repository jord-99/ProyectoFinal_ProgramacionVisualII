using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Modelo.Empresa;

namespace Info
{
    public class EmpleadoInfo : EntityInfo
    {
        public static new string Publicar(IDBEntity entidad)
        {
            Empleado empleado = (Empleado)entidad;
            return String.Format(
                " {0} \n {1}",
                empleado.EmpleadoId,
                empleado.NombreEmpleado
            );
        }
        public static new string Publicar(IEnumerable<IDBEntity> lista)
        {
            string mensaje = "Empleado ID \t Nombre del Empleado\n";
            var listaEmpleados = (List<Empleado>)lista;
            foreach (var empleado in listaEmpleados)
            {
                mensaje += String.Format(
                    "{0} \t {1}\n",
                    empleado.EmpleadoId,
                empleado.NombreEmpleado
                );
            }
            return mensaje;
        }
    }
}
