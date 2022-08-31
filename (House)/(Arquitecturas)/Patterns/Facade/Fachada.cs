namespace Subsistemas
{
    public class Fachada
    {
        private SistemaAlmacen almacen = new SistemaAlmacen();
        private SistemaCompras compras = new SistemaCompras();
        private SistemaEnvios envios = new SistemaEnvios();

        public void Compra()
        {
            if (compras.Comprar()) { if (almacen.SacarAlmacen()) envios.EnviarPedido(); }
        }
    }
}