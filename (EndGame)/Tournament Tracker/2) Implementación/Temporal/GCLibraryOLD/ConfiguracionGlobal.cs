using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLibrary
{
    public static class ConfiguracionGlobal
    {
        public static List<IConexion> Conexiones { get; private set; } = new List<IConexion>();
        public static void IniciarConexiones
            (
            bool sql_server,
            bool texto_plano
            )
        {
            if (sql_server)
            {
                // TODO Iniciar la conexión a la base de datos
                Conexiones.Add(new ConectorSQLServer());
            }
            if (texto_plano)
            {
                // TODO Iniciar la conexión a Archivo de Texto
                Conexiones.Add(new ConectorTextoPlano());
            }
        }
    }
}