using UIL.Modelo;
using UIL.Vista;

namespace UIL.Presentador
{
    public class RectanguloPresentador
    {
        readonly IRectangulo vista;

        public RectanguloPresentador(IRectangulo vista)
        {
            this.vista = vista;
        }

        public void CalcularArea()
        {
            Rectangulo rectangulo = new Rectangulo
            {
                Longitud = double.Parse(vista.LongitudCadena),
                Amplitud = double.Parse(vista.AmplitudCadena)
            };
            vista.AreaCadena = rectangulo.CalcularArea().ToString();
        }
    }
}
