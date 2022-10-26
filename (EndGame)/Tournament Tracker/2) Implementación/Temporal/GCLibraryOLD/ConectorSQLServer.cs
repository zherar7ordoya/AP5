using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLibrary
{
    public class ConectorSQLServer : IConexion
    {
        public PremioModel CrearPremio(PremioModel modelo)
        {
            // TODO Guardar el premio en la base de datos
            modelo.PremioID = 1;
            return modelo;
        }
    }
}