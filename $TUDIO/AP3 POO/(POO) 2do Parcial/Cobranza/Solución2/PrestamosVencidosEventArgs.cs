using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CANCELOS_POO_2P
{
    //Evento personalizado
    public class PrestamosVencidosEventArgs :  EventArgs
    {

        #region PROPIEDADES

        //declaro la lista pública, que es la que voy a mostrar cuando se dispare el evento
        public List<ClsPrestamo> PrestamosVencidos;

        #endregion

        #region CONSTRUCTORES
        public PrestamosVencidosEventArgs(List<ClsPrestamo> pListaPrestamos)
        {
            PrestamosVencidos = pListaPrestamos;
        }

        #endregion

        #region DESTRUCTOR

        ~PrestamosVencidosEventArgs() { }

        #endregion

    }
}
