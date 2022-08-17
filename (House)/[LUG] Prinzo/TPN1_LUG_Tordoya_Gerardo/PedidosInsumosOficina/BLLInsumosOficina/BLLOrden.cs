using System.Collections.ObjectModel;
using DALInsumosOficina;

namespace BLLInsumosOficina
{
    public class BLLOrden
    {
        //Relación 1 a muchos (parece que la única...)
        readonly ObservableCollection<BLLItem> listado = new ObservableCollection<BLLItem>();

        public ObservableCollection<BLLItem> ItemsListado
        {
            get { return listado; }
        }

        #region Métodos
        public void AgregarItem(BLLItem item)
        {
            foreach (var x in listado)
            {
                if (x.IdProducto == item.IdProducto)
                {
                    x.Cantidad += item.Cantidad;
                    return;
                }
            }
            listado.Add(item);
        }

        public void QuitarItem(string id)
        {
            foreach (var item in listado)
            {
                if (item.IdProducto == id)
                {
                    listado.Remove(item);
                    return;
                }
            }
        }

        public double ObtenerTotal()
        {
            if (listado.Count == 0)
            {
                return 0.00;
            }
            else
            {
                double total = 0;
                foreach (var item in listado)
                {
                    total += item.Total;
                }
                return total;
            }
        }

        public int RealizarPedido(int id)
        {
            string xmlOrden;
            xmlOrden = "<Orden IdEmpleado='" + id.ToString() + "'>";
            foreach (var item in listado)
            {
                xmlOrden += item.ToString();
            }
            xmlOrden += "</Orden>";
            DALOrden orden = new DALOrden();
            return orden.RealizarPedido(xmlOrden);
        }
        #endregion
    }
}