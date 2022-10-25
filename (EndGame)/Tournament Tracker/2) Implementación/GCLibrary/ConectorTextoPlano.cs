using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLibrary;

internal class ConectorTextoPlano : IConexion
{
    public PremioModel CrearPremio(PremioModel modelo)
    {
        // TODO Guardar el premio en un archivo de texto
        modelo.PremioID = 1;
        return modelo;
    }
}
