namespace Factory
{
    public interface IFabrica
    {
        void CrearProductos();
        IProductoLeche ObtenLeche { get; }
        IProductoSabor ObtenSabor { get; }
    }
}
