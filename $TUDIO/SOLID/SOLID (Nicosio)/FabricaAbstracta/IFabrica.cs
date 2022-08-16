namespace FabricaAbstracta
{
    public interface IFabrica
    {
        void CrearProducto();
        IProductoLeche ObtenerLeche { get; }
        IProductoSaborizante ObtenerSabor { get; }
    }
}
