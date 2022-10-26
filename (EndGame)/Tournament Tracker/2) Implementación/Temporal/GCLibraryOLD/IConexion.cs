using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLibrary
{
    public interface IConexion
    {
        PremioModel CrearPremio(PremioModel modelo);
    }
}