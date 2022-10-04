namespace FabricaAbstracta
{
    public interface IFabrica
    {
        void CrearProductos();
        IProductoLeche ObtenProductoLeche { get; }
        IProductoSaborizante ObtenSabor { get; }
    }
}
