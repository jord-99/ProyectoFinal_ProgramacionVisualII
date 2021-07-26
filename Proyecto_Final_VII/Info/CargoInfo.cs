using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Modelo.Empresa;
namespace Info
{
    public class CargoInfo: EntityInfo
    {
        public static new string Publicar(IDBEntity entidad)
        {
            Cargo cargo = (Cargo)entidad;
            return String.Format(
                "CragoId: {0} \n Descripcion del cargo: {1}\n Area: {2} \n Nombre del cargo: {3}",
                cargo.CargoId,
                cargo.DescripcionCargo,
                cargo.Area,
                cargo.NombreCargo
            );
        }

        public static new string Publicar(IEnumerable<IDBEntity> lista)
        {
            string msj = "Crago Id \t Descrpcion Cargo \t Area \t Nombre Cargo\n";
            var listaCargos = (List<Cargo>)lista;
            foreach (var cargo in listaCargos)
            {
                msj += String.Format(
                    "{0} \t {1} \t {2} \t {3}\n",
                    cargo.CargoId,
                cargo.DescripcionCargo,
                cargo.Area,
                cargo.NombreCargo
                );
            }
            return msj;
        }
    }
}
