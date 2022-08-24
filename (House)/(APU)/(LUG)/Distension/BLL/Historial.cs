using System.Data;

namespace BLL
{
    public class Historial
    {
        MPP.Historial HISTORIAL;

        public Historial()
        {
            HISTORIAL = new MPP.Historial();
        }

        public DataSet CargarDatosXML(BE.Historial objeto)
        {
            return HISTORIAL.CargarDatosXML(objeto);
        }

        public void ActualizarHistorial(BE.Historial objeto)
        {
            HISTORIAL.ActualizarHistorial(objeto);
        }
    }
}
