using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Modelo.Empresa;
namespace Info
{
    public class TiempoTrabajoEmpleadoInfo : EntityInfo
    {
        public static new string Publicar(IDBEntity entidad)
        {
            TiempoTrabajoEmpleado tiempotrabajo = (TiempoTrabajoEmpleado)entidad;
            return String.Format(
                " {0} \n {1} \n {2} \n",
                tiempotrabajo.TiempoTrabajoEmpleadoId,
                tiempotrabajo.FechaInicioTrabajo,
                tiempotrabajo.FechaFinTrabajo
                );
        }

        public static new string Publicar(IEnumerable<IDBEntity> lista)
        {
            string mensaje = "PeriodoId \t Estado \t Inicio \t Fin \n";
            var listaTiempoTrabajo = (List<TiempoTrabajoEmpleado>)lista;
            foreach (var tiempotrabajo in listaTiempoTrabajo)
            {
                mensaje += String.Format(
                    "{0} \t {1} \t {2} \n",
                   tiempotrabajo.TiempoTrabajoEmpleadoId,
                tiempotrabajo.FechaInicioTrabajo,
                tiempotrabajo.FechaFinTrabajo
                    );
            }
            return mensaje;
        }
    }
}
