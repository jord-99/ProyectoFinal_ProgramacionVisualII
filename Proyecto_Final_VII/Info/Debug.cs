using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Modelo.Empresa;
namespace Info
{
    public class Debug
    {
        public static void Print(IDBEntity empresa)
        {
            string msj = "";
            if (empresa is TiempoTrabajoEmpleado)
            {
                msj = TiempoTrabajoEmpleadoInfo.Publicar((TiempoTrabajoEmpleado)empresa);
            }
            else if (empresa is Empleado)
            {
                msj = EmpleadoInfo.Publicar((Empleado)empresa);
            }
            else if (empresa is Cargo)
            {
                msj = CargoInfo.Publicar((Cargo)empresa);
            }
            
            //
            Console.WriteLine(msj);
        }

        public static void Print(IEnumerable<IDBEntity> lista)
        {
            string msj = "";
            if (lista is List<TiempoTrabajoEmpleado>)
            {
                msj = TiempoTrabajoEmpleadoInfo.Publicar(lista);
            }
            else if (lista is List<Empleado>)
            {
                msj = EmpleadoInfo.Publicar(lista);
            }
            else if (lista is List<Cargo>)
            {
                msj = CargoInfo.Publicar(lista);
            }
           
            //
            Console.WriteLine(msj);
        }
    }
}
