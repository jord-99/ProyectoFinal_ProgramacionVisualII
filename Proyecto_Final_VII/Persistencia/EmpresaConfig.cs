using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Persistencia
{
    public class EmpresaConfig
    {
        public enum DestinoTipo { SQLServerEmpresa, PostgresEmpresa, MemoryEmpresa };
        const string KeyPersistenciaDestino = "PersistenciaDestino";
        static DestinoTipo PersistenciaDestino;
        static string StringConnection;

        static EmpresaConfig()
        {
            if (String.IsNullOrEmpty(StringConnection))
            {
                // Lectura de los parámetros del sistema
                PersistenciaDestino = (DestinoTipo)Enum.Parse(typeof(DestinoTipo), ConfigurationManager.AppSettings[KeyPersistenciaDestino].ToString());
                StringConnection = ConfigurationManager.ConnectionStrings[PersistenciaDestino.ToString()].ToString();
                // Debug
                Console.WriteLine(PersistenciaDestino + " --> " + StringConnection);
            }
        }

        static public void ContextOptions(DbContextOptionsBuilder optionsBuilder)
        {
            switch (PersistenciaDestino)
            {
                case DestinoTipo.SQLServerEmpresa:
                    optionsBuilder.UseSqlServer(StringConnection);
                    break;
                case DestinoTipo.PostgresEmpresa:
                    optionsBuilder.UseNpgsql(StringConnection);
                    break;
                case DestinoTipo.MemoryEmpresa:
                    optionsBuilder.UseInMemoryDatabase(StringConnection);
                    break;
                default:
                    break;
            }
        }
    }
}
