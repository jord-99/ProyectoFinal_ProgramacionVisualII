using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Modelo.Empresa;
   

namespace Info
{
   public class ConfiguracionInfo : EntityInfo
    {
        public new static string Publicar(IDBEntity entidad)
        {
            var configuracion = (Configuracion)entidad;
            return String.Format(
                "Nombre de la Empresa:  {0} \n Tiempo Vigente Id: {1} \n Salario Maximo: {2} \n Pago por las horas extras: {3} \n Horas extras maximas: {4} \n Horas extras minimas:  {5}",
                configuracion.NombreEmpresa,
                configuracion.TiempoVigenteId,
                configuracion.SalarioMaximo,
                configuracion.SalrioHorasExtras,
                configuracion.HorasExtrasMaximas,
                configuracion.HorasExtrasMinimas
                );
        }
        public static new string Publicar(IEnumerable<IDBEntity> lista)
        {
            string msj = "Nombre de la Empresa \t Tiempo Vigente Id \t Salario Maximo \t Pago Horas extras \n Horas extras maximas \n Horas extras minimas";
            var configuraciones = (List<Configuracion>)lista;
            foreach (var configuracion in configuraciones)
            {
                msj += String.Format(
                    "{0} \t {1} \t {2} \t {3} {4} {5} \n",
                   configuracion.NombreEmpresa,
                configuracion.TiempoVigenteId,
                configuracion.SalarioMaximo,
                configuracion.SalrioHorasExtras,
                configuracion.HorasExtrasMaximas,
                configuracion.HorasExtrasMinimas
                );
            }
            return msj;
        }
    }
}
